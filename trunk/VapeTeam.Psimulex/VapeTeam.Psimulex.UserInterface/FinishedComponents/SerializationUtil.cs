using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace VapeTeam.Psimulex.UserInterface
{
    /// <summary>
    /// Template to save and load Serialized Object to and from file.
    /// </summary>
    /// <typeparam name="T">The type of the object</typeparam>
    class SerializationUtil<Type>
    {
        /// <summary>
        /// Save an Object in a file.
        /// </summary>
        /// <param name="t">Object</param>
        /// <param name="filename">File</param>
        public virtual void Save(Type t, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            GZipStream gzipfs = new GZipStream(fs, CompressionMode.Compress);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(gzipfs, t);

            gzipfs.Close();
            fs.Close();
        }

        /// <summary>
        /// Load an Object from a file.
        /// </summary>
        /// <param name="filename">File</param>
        /// <returns>Object</returns>
        public virtual Type Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            GZipStream gzipfs = new GZipStream(fs, CompressionMode.Decompress);
            BinaryFormatter bf = new BinaryFormatter();

            Type t = (Type)bf.Deserialize(gzipfs);

            gzipfs.Close();
            fs.Close();

            return t;
        }
    }
}
