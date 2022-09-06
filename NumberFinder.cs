using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndAlgo
{
    public static class NumberFinder
    {
       public static void Number()
       {
            var startTime = DateTime.Now;
            int n = 10000000;
            int x = 9999996;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count++;
                if (i == x)
                {
                    Console.WriteLine("We have found the values at {0} try", count);
                    break;
                }
            }
            var endTime = DateTime.Now;
            var timeDiff = endTime - startTime;
            Console.WriteLine("It took {0} to run this algorithm", timeDiff.TotalMilliseconds);
        }
        public static void NumberOptimized()
        {
            var startTime = DateTime.Now;
            int n = 10000000;
            int x = 9999996;
            int count = 0;
            bool isEven = x % 2 == 0;
            if(isEven)
            {
                for (int i = 2; i < n; i = i + 2)
                {
                    count++;
                    if (i == x)
                    {
                        Console.WriteLine("We have found the values at {0} try", count);
                        break;
                    }
                }
            }
           
            var endTime = DateTime.Now;
            var timeDiff = endTime - startTime;
            Console.WriteLine("It took {0} to run this algorithm", timeDiff.TotalMilliseconds);
        }

    }
}
