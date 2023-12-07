using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L37_сombiningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array1 = new List<int>() { 1, 2, 1 };
            List<int> array2 = new List<int>() { 3, 2, 3, 3, 5, 2, 7 };
            List<int> finalArray = new List<int>();

            MergeArrays(finalArray, array1);
            MergeArrays(finalArray, array2);

            WriteArray(finalArray);
            Console.WriteLine();
        }

        static void MergeArrays(List<int> finalArray, List<int> array)
        {
            foreach (var item in array)
                if (finalArray.Contains(item) == false)
                    finalArray.Add(item);
        }

        static void WriteArray(List<int> array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
        }
    }
}
