using System;
using System.Collections.Generic;
using System.Text;

namespace MyTools.Number
{
     public class Calculator
     {
        public static double Mean(double[] arr)
        {
            double s = 0;
            int len = arr.Length;
            for (int i = 0; i < len; i++)
                s += arr[i];
            return s / len;
        }
        public static double Mean(int[] arr)
        {
            double s = 0;
            int len = arr.Length;
            for (int i = 0; i < len; i++)
                s += arr[i];
            return s / len;
        }
        public static double Var(double[] arr)
        {
            double s1 = 0, s2 = 0;
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                s1 += arr[i] * arr[i];
                s2 += arr[i];
            }
            double EX2 = s1 / len;
            double EX = s2 / len;
            return EX2 - EX * EX;
        }
    }
}
