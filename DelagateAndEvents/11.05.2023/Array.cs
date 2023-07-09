using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._11._05._2023
{

    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public  class Array : ICalc
    {
        List<int> values;
        public int lenght;

        public Array(List<int> values, int lenght)
        {
            this.values = values;
            this.lenght = lenght;
        }

        public int Greater(int valueToCompare)
        {
            int rezult = 0;
            foreach(var item in values)
            {
                if(item < valueToCompare)
                {
                    rezult++;  
                }
            }
            return rezult;
        }

        public int Less(int valueToCompare)
        {
            int rezult = 0;
            foreach (var item in values)
            {
                if (item > valueToCompare)
                {
                    rezult++;
                }
            }
            return rezult;
        }
    }
}
