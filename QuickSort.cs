using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice
{
    class QuickSort
    {
        public static void partition(int startIndex, int endIndex, int[] arrayToPartition)
        {
            if (startIndex < endIndex)
            {
                int pivotValue = arrayToPartition[endIndex];
                int pivotIndex = startIndex;

                for (int i = startIndex; i < endIndex; i++)
                {
                    if (arrayToPartition[i] <= pivotValue)
                    {
                        int tempPivot = arrayToPartition[i];
                        arrayToPartition[i] = arrayToPartition[pivotIndex];
                        arrayToPartition[pivotIndex] = tempPivot;
                        pivotIndex++;
                    }
                }

                int tempPartition = arrayToPartition[endIndex];
                arrayToPartition[endIndex] = arrayToPartition[pivotIndex];
                arrayToPartition[pivotIndex] = tempPartition;

                partition(startIndex, pivotIndex - 1, arrayToPartition);
                partition(pivotIndex + 1, endIndex, arrayToPartition);
            }


        }
    }
}
