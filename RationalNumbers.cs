using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson5.Task1_2
{
   internal class RationalNumbers
    {
        private int Nominator;
        private int Denominator;

        internal RationalNumbers()
        {
            
        }
        public static bool operator ==(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }
        public static bool operator !=(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator >(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }
        public static bool operator <(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }

        public static bool operator >=(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }
        public static bool operator <=(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }
        public static bool operator +(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }
        public static bool operator -(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }

        public static RationalNumbers operator ++(RationalNumbers Nominator)
        {
            return new RationalNumbers() { };
        }
        public static RationalNumbers operator --(RationalNumbers Nominator)
        {
            return new RationalNumbers() { };
        }

        public static bool operator *(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }
        public static bool operator /(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }

        public static bool operator %(RationalNumbers Nominator, RationalNumbers Denominator)
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public static implicit operator float(RationalNumbers rational)
        {
            
                return rational.Nominator/rational.Denominator;
        }
        public static explicit operator int (RationalNumbers rational)
        {
            return (int)rational.Nominator;
        }



    }
}
