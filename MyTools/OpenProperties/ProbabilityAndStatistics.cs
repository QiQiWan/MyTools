using System;

namespace MyTools
{
    /// <summary>
    /// 简单的概率库
    /// </summary>
    static public class ProbabilityAndStatistics
    {
        /// <summary>
        /// 传入伯努利试验次数，期望，和概率。返回满足二项分布的概率（计算量较大，效率过低）
        /// </summary>
        /// <param name="N">伯努利实验次数</param>
        /// <param name="k">成功期望</param>
        /// <param name="p">概率</param>
        /// <returns></returns>
        public static double binomial(int N, int k, double p)
        {
            if (N == 0 && k == 0) return 1.0;
            if (N < 0 || k < 0) return 0.0;
            return (1.0 - p) * binomial(N - 1, k, p) + p * binomial(N - 1, k - 1, p);
        }
        /// <summary>
        /// 返回真的概率为p
        /// </summary>
        /// <param name="p">返回真的概率</param>
        /// <returns></returns>
        public static bool bernoulli(double p)
        {
            if (new Random().NextDouble() < p) return true;
            else return false;
        }
        /// <summary>
        /// 返回随机打乱后的数组
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="a">要打乱的数组</param>
        /// <returns></returns>
        public static T[] shuffle<T>(T[] a)
        {
            int N = a.Length;
            for(int i = 0; i < N; i++)
            {
                int r = i + new Random().Next(N - i - 1);
                T temp = a[i];
                a[i] = a[r];
                a[r] = temp;
            }
            return a;
        }
    }

    public class ProbabilityDraw
    {

    }
}
