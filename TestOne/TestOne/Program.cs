using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOne
{
    class Program
    {
        private delegate void del(List<int> arrayList);

        private static List<int> CreatorList(int minC = 20, int maxC = 100,
            int minD = -100, int maxD = 100)
        {
            List<int> list = new List<int>();
            int CountNumber = new Random().Next(minC, maxC);
            Random rnd = new Random();
            for (int i = 0; i < CountNumber; i++)
            {
                int rNumber = rnd.Next(minD, maxD);
                list.Add(rNumber);
            }
            return list;
        }

        static void Main(string[] args)
        {
            HeapSort heapSort = new HeapSort();
            ShellSort shellSort = new ShellSort();
            RestAPI aPI = new RestAPI();

            del[] metodsSort = { shellSort.Shellsort, heapSort.Heapsort };

            List<int> listInt = CreatorList();

            metodsSort[new Random().Next(0, metodsSort.Length)](listInt);

            Console.WriteLine("Sorted Array: {0}", string.Join(" ", listInt));

            aPI.RestClient(listInt);

            Console.ReadKey();

        }
    }
}
