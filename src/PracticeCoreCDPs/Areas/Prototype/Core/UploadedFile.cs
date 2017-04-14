using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PracticeCoreCDPs.Areas.Prototype.Core
{
    [Serializable]
    public class UploadedFile : IUploadedFile
    {
        public string FileName { get; set; }
        public long Size { get; set; }
        public string ContentType { get; set; }
        public DateTime TimeStamp { get; set; }
        public byte[] FileContent { get; set; }
        public IUploadedFile Clone()
        {
            return (IUploadedFile) this.MemberwiseClone();
        }

        public IUploadedFile DeepCopy()
        {
            if (!this.GetType().IsSerializable)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                formatter.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                IUploadedFile deepcopy = (IUploadedFile) formatter.Deserialize(ms);
                ms.Close();
                return deepcopy;
            }

            return null;
        }
    }
}
