using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson5.Task1_2
{
    class ComplexNumber
    {
        internal double r, i;
        public static ComplexNumber operator + (ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.r = a.r + b.r;
            complex.i = a.i + b.i;
            return complex;
        }

        public static ComplexNumber operator - (ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.r = a.r - b.r;
            complex.i = a.i - b.i;
            return complex;
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.r = a.r * b.r;
            complex.i = a.i * b.i;
            return complex;
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            
            bool Result = ReferenceEquals(a, b);
            return Result;
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
