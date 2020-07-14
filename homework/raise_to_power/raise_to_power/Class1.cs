using System;

namespace raise_to_power
{
    public class Class1
    {
        public static double RaiseToPower(double x, double y, int p)
        {
            // 2, 3, 3  ==> (2*3)=6 and raise this to power 3 ie 36*6=216
            return Math.Pow((x * y), p);
        }
    }
}
