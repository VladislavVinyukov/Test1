using System;
using System.Collections.Generic;

namespace TestOne
{
    class ShellSort
    {
        public void Shellsort(List<int> arr)
        {

            Console.WriteLine("Shell Sort");
            var d = arr.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        var t = arr[j];
                        arr[j] = arr[j - d];
                        arr[j - d] = t;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
        }
    }
}
