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

            ArraysLinq(finalArray, array1);
            ArraysLinq(finalArray, array2);

            WriteArray(finalArray);
            Console.WriteLine();
        }

        private static void ArraysLinq(List<int> finalArray, List<int> array)
        {
            if (finalArray.Count == 0)
                finalArray.Add(array[0]);

            for (int i = 0; i < array.Count; i++)
            {
                bool isCopy = false;

                for (int j = 0; j < finalArray.Count; j++)
                {
                    if (finalArray[j] == array[i])
                        isCopy = true;
                }

                if (isCopy == false)
                    finalArray.Add(array[i]);
            }
        }

        static void WriteArray(List<int> array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
        }
    }
}
