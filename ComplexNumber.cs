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
            
            bool Result1 = ReferenceEquals(a, null);
            bool Result2 = ReferenceEquals(b,null);

            if (a.i == b.i && a.r == b.r && Result1==false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            bool Result1 = ReferenceEquals(a, null);
            bool Result2 = ReferenceEquals(b, null);

            if (a.i != b.i || a.r != b.r || Result1== true || Result2==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj) => this.Equals(obj as ComplexNumber);
        public bool Equals(ComplexNumber a)
        {

            
            return this.i == a.i && this.r == a.r;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "new ToString()";
        }


    }
}
