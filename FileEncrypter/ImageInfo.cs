using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEncrypter
{

    [Serializable]
    internal class ImageInfo
    {

        public byte[] Matrix { get; set; }

        public byte[]  Password { get; set; }

        internal ImageInfo(byte[] matrix,byte[] password)
        { 
        
            Matrix = matrix;
            Password = password;
        
        }


    }
}
