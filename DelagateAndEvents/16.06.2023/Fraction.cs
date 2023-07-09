using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DelagateAndEvents._16._06._2023
{
    [Serializable]
    public class Fraction
    {
        [XmlElement("Numerator")]
        public float Numerator { get; set; }

        [XmlElement("Denominator")]
        public float Denominator { get; set; }

        public Fraction()
        {
            Numerator = 0.0f;
            Denominator = 1.0f;
        }
        public Fraction(Fraction frac)
        {
            this.Denominator = frac.Denominator;
            this.Numerator = frac.Numerator;
        }
        public Fraction(float numerator, float denominator)
        {
            Numerator = numerator;
            if (denominator == 0)
            {
                Denominator = 1.0f;
            }
            else
            {
                Denominator = denominator;
            }
        }


        public override string ToString() 
        {
            return $"Numerator {Numerator}\n--\nDenominator {Denominator}\n";
        }


    }
}
