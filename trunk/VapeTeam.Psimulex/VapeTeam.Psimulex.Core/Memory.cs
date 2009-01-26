using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    public class Memory
    {
        #region MemoryListener

        internal class AutoCleanup : IDisposable
        {
            public List<BaseType> UndeletedValues { get; private set; }

            private bool isDisposing = false;

            public AutoCleanup()
            {
                UndeletedValues = new List<BaseType>();
                Memory.Instance.ValueAllocated += new EventHandler<ValueEventArgs>(Instance_ValueAllocated);
                Memory.Instance.ValueDeAllocated += new EventHandler<ValueEventArgs>(Instance_ValueDeAllocated);
            }

            void Instance_ValueDeAllocated(object sender, ValueEventArgs e)
            {
                if (!isDisposing)
                {
                    UndeletedValues.Remove(e.Value);
                }
            }

            void Instance_ValueAllocated(object sender, ValueEventArgs e)
            {
                if (!isDisposing)
                {
                    UndeletedValues.Add(e.Value);
                }
            }

            #region IDisposable Members

            public void Dispose()
            {
                isDisposing = true;
                UndeletedValues.ForEach(v => v.Delete());
                Memory.Instance.ValueAllocated -= this.Instance_ValueAllocated;
                Memory.Instance.ValueDeAllocated -= this.Instance_ValueDeAllocated;
            }

            #endregion
        }

        #endregion

        #region Singleton

        private static Memory _currentMemoryInstance;
        public static Memory Instance
        {
            get
            {
                if (_currentMemoryInstance == null)
                    _currentMemoryInstance = new Memory();
                return _currentMemoryInstance;
            }
            set
            {
                _currentMemoryInstance = value;
            }
        }

        #endregion

        #region Events

        internal class ValueEventArgs : EventArgs
        {
            public BaseType Value { get; set; }
        }

        internal event EventHandler<ValueEventArgs> ValueAllocated;
        internal protected virtual void OnValueAllocated(BaseType value)
        {
            if (ValueAllocated != null)
            {
                ValueAllocated(this, new ValueEventArgs { Value = value });
            }
        }

        internal event EventHandler<ValueEventArgs> ValueDeAllocated;
        internal protected virtual void OnValueDeAllocated(BaseType value)
        {
            if (ValueDeAllocated != null)
            {
                ValueDeAllocated(this, new ValueEventArgs { Value = value });
            }
        }

        #endregion

        #region Private fields

        private int _size;

        // 32 bit
        private int _addressLength = 4;

        public virtual int AddressLength
        {
            get
            {
                return _addressLength;
            }
        }

        /// <summary>
        /// If true then no events should be fired.
        /// </summary>
        private bool _isRelocating = false;

        /// <summary>
        /// The memory itself. It is an extensible list where the freed blocks are represented by nulls.
        /// </summary>
        private List<BaseType> _memoryRep;

        /// <summary>
        /// It stores the size of each allocation in memory blocks to be able to free it properly
        /// (not based on the BaseType's current MemorySize which may change).
        /// </summary>
        private Dictionary<int, int> _allocationSizeInfo;

#if DEBUG

        /// <summary>
        /// It helps to find memory leaks in the core storing the full stack trace of the allocation command.
        /// </summary>
        private Dictionary<int, string> _allocationDebugInfo = new Dictionary<int, string>();

        /// <summary>
        /// Allocation informations grouped by the stack trace string and counted.
        /// </summary>
        private object _collectedLeakInformation
        {
            get
            {
                return
                    _allocationDebugInfo.GroupBy(g => g.Value).Select(g => new { Trace = g.Key, Count = g.Count() });
            }
        }

#endif

        #endregion

        /// <summary>
        /// Hide constructor
        /// </summary>
        private Memory(int size)
        {
            _size = size;
            _memoryRep = new List<BaseType>(_size / _addressLength);
            _allocationSizeInfo = new Dictionary<int, int>(_size);
        }

        private Memory()
            : this(16384)
        {

        }

        /// <summary>
        /// Creates the Memory.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Memory CreateMemory(int size)
        {
            // Todo: validate size
            return new Memory(size);
        }

        private Dictionary<int, int> referenceCounter = new Dictionary<int, int>();

        //public static int Allocate(int bytes)
        //{
        //    return _currentMemoryInstance.Allocate(bytes);
        //}

        private int GetNumberOfBlocksToReserve(int bytes)
        {
            return (bytes / _addressLength + (bytes % _addressLength > 0 ? 1 : 0));
        }

        /// <summary>
        /// Find the first free position in the memory that is coherent.
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        protected virtual int FindFreeLocation(int bytes)
        {
            // Round bytes to fit memory blocks
            int numberOfBlocksToReserve = GetNumberOfBlocksToReserve(bytes);

            int freeSpaceStart = 0;
            for (int i = 0; i < _memoryRep.Count; ++i)
            {
                if (_memoryRep[i] != null)
                    freeSpaceStart = i + 1;

                // If it is big enough then break
                if (i - freeSpaceStart + 1 == numberOfBlocksToReserve)
                    break;
            }

            if (_memoryRep.Count - 1 - freeSpaceStart < numberOfBlocksToReserve)
            {
                freeSpaceStart = _memoryRep.Count;
            }

            if ((freeSpaceStart + numberOfBlocksToReserve) * _addressLength > _size)
            {
                throw new VapeTeam.Psimulex.Core.Exceptions.MemoryException("Out of memory.");
            }

            return freeSpaceStart;
        }

        /// <summary>
        /// Sets the given position of the memory.
        /// </summary>
        /// <param name="memoryPos"></param>
        /// <param name="value"></param>
        protected virtual void SetMemory(int memoryPos, BaseType value)
        {
            int numberOfBlocksToSet = GetNumberOfBlocksToReserve(value.MemorySize);

            // If the object needs more blocks, then we will provide it but every block will contain the same reference to the object.
            // We don't care about the inner memory representation of the object.
            // Perhaps later an [InMemory] attribute would be good to indicate that a field should be automatically stored 
            // in the memory by the allocator routine. And freed after deallocation of course.
            for (int i = memoryPos; i < memoryPos + numberOfBlocksToSet; ++i)
            {
                if (_memoryRep.Count <= i)
                    _memoryRep.Add(null);
                _memoryRep[i] = value;
            }

            _allocationSizeInfo.Add(memoryPos, numberOfBlocksToSet);
        }

        public virtual int TotalMemory
        {
            get
            {
                return _size * _addressLength;
            }
        }

        public virtual int Reserved
        {
            get
            {
                return _memoryRep.Count * _addressLength;
            }
        }

        public virtual int AllocatedBytes
        {
            get
            {
                return _memoryRep.Count(x => x != null) * _addressLength;
            }
        }

        public virtual int Free
        {
            get
            {
                return TotalMemory - Reserved;
            }
        }

        /// <summary>
        /// Allocates the value and increases the reference counter.
        /// </summary>
        /// <param name="baseType"></param>
        public virtual void Allocate(VapeTeam.Psimulex.Core.Types.BaseType baseType)
        {
            return; // Temporary
            if (referenceCounter.ContainsKey(baseType.MemoryAddress))
                return;
            int pos = 0;
            SetMemory(pos = FindFreeLocation(baseType.MemorySize), baseType);
            baseType.MemoryAddress = pos;
            baseType.isAllocated = true;

            if (!_isRelocating)
            {
                OnValueAllocated(baseType);
            }

#if DEBUG
            _allocationDebugInfo.Add(pos, System.Environment.StackTrace);
#endif

            referenceCounter.Add(pos, 1);

            if (baseType is ReferenceType)
            {
                var deref = baseType.Dereference();
                // If a referencedValue is being constructed it may not be set to point to an existing value yet.
                if (deref != null)
                {
                    int refCount = 0;
                    if (referenceCounter.TryGetValue(deref.MemoryAddress, out refCount))
                    {
                        referenceCounter[deref.MemoryAddress] = ++refCount;
                    }
                }
            }
        }

        public static void Reset()
        {
            Instance = new Memory();
        }

        /// <summary>
        /// Deallocates the current instance of the baseType. If it is referenced by other value then it will stay 
        /// in the memory with decreased reference counter.
        /// It a referenceValue is being deallocated then its referenced value will be also deallocated.
        /// </summary>
        /// <param name="baseType"></param>
        public virtual void DeAllocate(BaseType baseType)
        {
            return; // Temporary
            int refCount = 0;
            if (referenceCounter.TryGetValue(baseType.MemoryAddress, out refCount))
            {
                referenceCounter[baseType.MemoryAddress] = --refCount;
            }
            else
            {
                // If there is no reference, then probably an error occured (NullReference if you like)
                throw new VapeTeam.Psimulex.Core.Exceptions.MemoryException("Trying to delete an already deallocated value.");
            }

            if (refCount == 0)
            {
                // There is no more reference to the instance of object so free up the consumed memory.
                FreeMemory(baseType);
            }

            if (baseType is ReferenceType)
            {
                refCount = 0;
                var deref = baseType.Dereference();
                if (referenceCounter.TryGetValue(deref.MemoryAddress, out refCount))
                {
                    DeAllocate(deref);
                }
            }
        }

        /// <summary>
        /// Frees the memory. Removes all information that is stored related to the value.
        /// </summary>
        /// <param name="baseType"></param>
        private void FreeMemory(BaseType baseType)
        {
            referenceCounter.Remove(baseType.MemoryAddress);
            int memPos = baseType.MemoryAddress;
            int allocatedSize = _allocationSizeInfo[memPos];
            for (int i = 0; i < allocatedSize; ++i)
            {
                _memoryRep[memPos + i] = null;
            }
            _allocationSizeInfo.Remove(memPos);

            baseType.isAllocated = false;

            if (!_isRelocating)
            {
                OnValueDeAllocated(baseType);
            }

#if DEBUG
            // The allocations that has already been freed are not too interesting in order to find leaks.
            _allocationDebugInfo.Remove(memPos);
#endif
        }

        /// <summary>
        /// Reallocates the object in the memory. It is necessary if the memory usage of an object changes.
        /// </summary>
        /// <param name="value"></param>
        public virtual void ReAllocate(BaseType value)
        {
            return;
            if (!_allocationSizeInfo.ContainsKey(value.MemoryAddress))
            {
                throw new VapeTeam.Psimulex.Core.Exceptions.MemoryException("Trying to reallocate a value that has been freed or not allocated yet.");
            }

            int noBlocksNeeded = GetNumberOfBlocksToReserve(value.MemorySize);

            if (_allocationSizeInfo[value.MemoryAddress] == noBlocksNeeded)
            {
                // Reallocation is not effective if the memory need hasn't changed.
                return;
            }

            _isRelocating = true;
            // Free the currently reserved memory space
            int currentReferenceCounter = referenceCounter[value.MemoryAddress];
            FreeMemory(value);

            // Let the manager place it somewhere else
            Allocate(value);
            // Restore the reference counter
            referenceCounter[value.MemoryAddress] = currentReferenceCounter;
            _isRelocating = false;

            // Reference objects pointing this value will know its new memory address because it is stored in the value itself.
        }
    }
}
