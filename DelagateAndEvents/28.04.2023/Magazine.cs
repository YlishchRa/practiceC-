using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._28._04._2023
{
    internal class Magazine
    {
        public int workers;
        public static Magazine operator +(Magazine m1, int value)
        {
            m1.workers += value;

            return m1;
        }
        public static Magazine operator -(Magazine m1, int value)
        {
            m1.workers -= value;
            return m1;
        }
        public static bool operator ==(Magazine m1, int value)
        {
            return !(m1.workers != value);
        }

        public static bool operator !=(Magazine m1, int value)
        {
            return m1.workers != value;
        }

        public static bool operator >(Magazine m1, int value)
        {
            return m1.workers > value;
        }

        public static bool operator <(Magazine m1, int value)
        {
            return m1.workers < value;
        }
        public override bool Equals(object? obj)
        {
            if(obj is Magazine other)
            {
                return workers == other.workers;
            }
            return false;
        }
    }
}
