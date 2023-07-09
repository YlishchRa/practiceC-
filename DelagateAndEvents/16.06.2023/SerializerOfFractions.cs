using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace DelagateAndEvents._16._06._2023
{


    [Serializable]
    public class SerializerOfFractions
    {

        List<Fraction> fractions { get; set; }

        public SerializerOfFractions()
        {
            fractions = new List<Fraction>();
        }

        public void AddFraction()
        {
            Console.WriteLine("Enter the numerator");
            float numerator = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the denominator");
            float denominator = float.Parse(Console.ReadLine());

            fractions.Add(new Fraction(numerator, denominator));


        }

        public void AddFraction(Fraction frac)
        {
            fractions.Add(new Fraction(frac));
        }


        public void Serialize()
        {
            using (Stream stream = File.Create("file.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Fraction>));
                serializer.Serialize(stream, fractions);
            }
        }

        public List<Fraction>? Deserialize()
        {
            List<Fraction>? list = null;
            using (Stream stream = File.OpenRead("file.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Fraction>));
                list = (List <Fraction>)serializer.Deserialize(stream);
            }
            return list;
        }
    }


    //SerializerOfFractions s = new SerializerOfFractions();
    //s.AddFraction(new Fraction(1, 4));
    //s.AddFraction(new Fraction(5, 0));
    //s.AddFraction(new Fraction(4, 0));
    //s.AddFraction(new Fraction(-10, 10));
    //s.AddFraction(new Fraction(2, 2));
    //s.AddFraction(new Fraction(3, 3));
    //s.Serialize();

    //List<Fraction> list = s.Deserialize();

    //foreach(Fraction item in list)
    //{
    //    Console.WriteLine(item);
    //}
}
