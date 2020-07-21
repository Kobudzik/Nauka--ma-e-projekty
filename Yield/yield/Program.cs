using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yield
{
    class Program
    {
        public static void Consumer()
        {
            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }
        }

        public static IEnumerable<int> Integers() //method
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield break;
            yield return 16777216;
            //IEnumerable<int> Konrad = new int[] { 3, 4, 5 };
            //return Konrad;

        }

        static void Main(string[] args)
        {
            Consumer();

            Console.Read();
        }
    }
}
