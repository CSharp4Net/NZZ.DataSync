using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZZ.DataSync.Logic.Statics
{
    public static class MD5
    {
        public static bool ComputeMD5(string filePath, string checkSum)
        {
            byte[] md5Hash;

            //Datei einlesen
            using (System.IO.FileStream fs = System.IO.File.OpenRead(filePath))
            {
                // MD5-Hash aus dem Byte-Array berechnen
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                md5Hash = md5.ComputeHash(fs);
                fs.Close();
            }

            //in string wandeln
            string backUpCheckSum = BitConverter.ToString(md5Hash).Replace("-", string.Empty).ToLower();

            // Vergleichen
            if (backUpCheckSum == checkSum.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
