using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice
{
    class MergeSort
    {
        public static void sortIntArray(int[] arrayToSort)
        {
            if (arrayToSort.Length > 1)
            {
                int midpoint = arrayToSort.Length / 2;
                var a = new int[midpoint];
                var b = new int[arrayToSort.Length - midpoint];

                for (int i = 0; i < midpoint; i++)
                {
                    a[i] = arrayToSort[i];
                }
                for (int i = midpoint; i < arrayToSort.Length; i++)
                {
                    b[i - midpoint] = arrayToSort[i];
                }

                sortIntArray(a);
                sortIntArray(b);
                merge(a, b, arrayToSort);
            }
        }
        public static void merge(int[] a, int[] b, int[] source)
        {
            int indexA = 0;
            int indexB = 0;
            int counter = 0;

            while (indexA < a.Length && indexB < b.Length)
            {
                if (a[indexA] <= b[indexB])
                {
                    source[counter] = a[indexA];
                    indexA++;
                }
                else
                {
                    source[counter] = b[indexB];
                    indexB++;
                }
                counter++;
            }
            while (indexA < a.Length)
            {
                source[counter] = a[indexA];
                indexA++;
                counter++;
            }
            while (indexB < b.Length)
            {
                source[counter] = b[indexB];
                indexB++;
                counter++;
            }
        }
    }
}
