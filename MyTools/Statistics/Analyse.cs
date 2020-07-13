using System;
using System.Collections.Generic;
using System.Text;

namespace MyTools.Statistics
{
    public class Analyse
    {
        public delegate double Fx(double x);

        public static double Newton_Raphson_Method(double x0, Fx fx, Fx f_x)
        {
            double record = x0, xl;
            while (fx(x0) / f_x(x0) < 0.0000001)
            {
                xl = x0 - fx(x0) / f_x(x0);
                if (xl == record)
                    throw new Exception("到达极值点,无法迭代!");
                else
                    record = x0;
                x0 = xl;
            }
            return x0;
        }
    }
}
