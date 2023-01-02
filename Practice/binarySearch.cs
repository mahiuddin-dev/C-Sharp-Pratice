using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class BinarySearch
    {
        public int find(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid;

            while(left <= right)
            {
                mid = (left + right) / 2;
                if (key == arr[mid])
                {
                    return 1;
                } else if( key < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
