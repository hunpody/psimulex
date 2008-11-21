using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    public class Memory
    {
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
        
        private int _size;

        // 32 bit
        private int _addressLength = 4;

        private List<BaseType> _memoryRep;

        /// <summary>
        /// Hide constructor
        /// </summary>
        private Memory(int size)
        {
            _size = size;
            _memoryRep = new List<BaseType>(_size / _addressLength);
        }

        private Memory()
            :this(16384)
	    {
            
	    }

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

        /// <summary>
        /// Find the first free position in the memory.
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        protected virtual int FindFreeLocation(int bytes)
        {
            int lastIndex = _memoryRep.FindIndex(x => x == null);
            if (lastIndex == -1)
            {
                lastIndex = _memoryRep.Count;
            }
            if (lastIndex * _addressLength > _size)
            {
                throw new VapeTeam.Psimulex.Core.Exceptions.MemoryException("Out of memory.");
            }
            return lastIndex;
        }     

        /// <summary>
        /// Sets the given position of the memory.
        /// </summary>
        /// <param name="memoryPos"></param>
        /// <param name="value"></param>
        protected virtual void SetMemory(int memoryPos, BaseType value)
        {
            if (memoryPos < _memoryRep.Count)
            {
                _memoryRep[memoryPos] = value;
            }
            else
            {
                while ( _memoryRep.Count <= memoryPos)
                {
                    _memoryRep.Add(null);
                }
                _memoryRep[memoryPos] = value;
            }
        }

        public int TotalMemory
        {
            get
            {
                return _size * _addressLength;
            }
        }

        public int Reserved
        {
            get
            {
                return _memoryRep.Count * _addressLength;
            }
        }

        public int AllocatedBytes
        {
            get
            {
                return _memoryRep.Count(x => x != null) * _addressLength;
            }
        }

        public int Free
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
        public int Allocate(VapeTeam.Psimulex.Core.Types.BaseType baseType)
        {
            int pos = 0;
            SetMemory(pos = FindFreeLocation(_addressLength), baseType);
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
            return pos;
        }

        public static void Reset()
        {
            Instance = new Memory();
        }

        public void DeAllocate(BaseType baseType)
        {
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
                referenceCounter.Remove(baseType.MemoryAddress);
                var memPos = _memoryRep.FindIndex(x => x == baseType);
                if (memPos != -1)
                    _memoryRep[memPos] = null;
            }

            if (baseType is ReferenceType)
            {
                refCount = 0;
                var deref = baseType.Dereference();
                if (referenceCounter.TryGetValue(deref.MemoryAddress, out refCount))
                {
                    DeAllocate(deref);
                    //referenceCounter[deref.MemoryAddress] = --refCount;

                    //if (refCount == 1)
                    //{
                    //    DeAllocate(deref);
                    //}
                }
            }

            //int pos = 0;
            //SetMemory(pos = FindFreeLocation(_addressLength), baseType);
        }
    }
}
