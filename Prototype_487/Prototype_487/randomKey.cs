using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_487
{
    class randomKey
    {
        public static string makeKeyRandonly(string key)
        {           
            return RandomString(128);
        }

        private static Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);//랜덤 시드값

        public static string RandomString(int _nLength = 128)
        {
            const string strPool = "0123456789"; //문자 생성 풀
            char[] chRandom = new char[_nLength];

            for (int i = 0; i < _nLength; i++)
            {
                chRandom[i] = strPool[random.Next(strPool.Length)];
            }
            string strRet = new String(chRandom);  // char to string
            return strRet;
        }
    }
}
