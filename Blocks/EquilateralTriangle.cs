using System;

namespace Blocks_Main
{
    internal class EquilateralTriangle :Triangle
    {
        // changed int a to double a
        public EquilateralTriangle(double a):base(a,a,a)
        {
            if (a <= 0) throw new ArgumentException("Give side greater than 0");
        }
    }
}