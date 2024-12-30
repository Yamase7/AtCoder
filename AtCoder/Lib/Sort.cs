using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Lib
{
    public static class Sort
    {
        public static void QuickSort(long[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            // 中央のインデックスをピボットとする
            var mid = start + (end - start) / 2;
            var pivot = Medium(array[start], array[mid], array[end]);

            // 左右のノードを設定
            int left = start;
            int right = end;

            while (true)
            {
                // 左から探索
                while (array[left] < pivot)
                {
                    left++;
                }

                // 右から探索
                while (array[right] > pivot)
                {
                    right--;
                }

                // 超えたらソート終了
                if (left >= right)
                {
                    break;
                }

                // 探索した値を交換
                var tmp = array[left];
                array[left] = array[right];
                array[right] = tmp;

                // インデックスを進めて探索を再開
                left++;
                right--;
            }

            QuickSort(array, start, left - 1);
            QuickSort(array, right + 1, end);
        }

        public static long Medium(long left, long mid, long right)
        {
            if (left < mid)
            {
                if (mid < right)
                {
                    return mid;
                }
                else if (right < left)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
            else
            {
                if (right < mid)
                {
                    return mid;
                }
                else if (left < right)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
