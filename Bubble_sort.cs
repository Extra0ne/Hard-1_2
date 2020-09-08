using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_1_2
{
    class Bubble_sort
    {
        public static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Exchange_of_elements.Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}
