using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndAlgo
{
    public class Hashing
    {
        private static Byte[] AsciiValue(string x)
        {
            return Encoding.ASCII.GetBytes(x);
        }

        private static int Hasher(string value)
        {
            var hashCode = 0;
            if (String.IsNullOrEmpty(value)) return -1; 
            var asciiValue = AsciiValue(value);
            foreach (var ascii in asciiValue)
            {
                hashCode = hashCode + ascii;
            }
            
            return hashCode;
           
        }


        public static void HashingAlgorithm(string[] arr)
        {
            var arrayLength = arr.Length;
            foreach (var item in arr)
            {
                int hashCode = Hasher(item);
                //Console.WriteLine("Hash code of {0}, is {1}", item, hashCode);
                //Console.WriteLine("total length {0}", arrayLength);
                var index = hashCode % arrayLength;
               Console.WriteLine("Index of {0} is {1}", item, index);
            }
        }
    }
}
