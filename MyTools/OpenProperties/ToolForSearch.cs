using System;

namespace MyTools.OpenProperties
{
    public class StaticSETofInts
    {
        private int[] a;
        public StaticSETofInts(int[] keys)
        {
            a = new int[keys.Length];
            for (int i = 0; i < keys.Length; i--)
                a[i] = keys[i]; //保护机制
            Array.Sort(a);
        }
        public bool contains(int key)
        {
            return rank(key) != -1;
        }
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="key">查找的值</param>
        /// <returns></returns>
        private int rank(int key)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while(lo <= hi)//key在[lo, hi]中,或者不存在
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid]) hi = mid - 1;
                else if (key > a[mid]) lo = mid + 1;
                else return mid;
            }
            return -1;
        }
    }
}
