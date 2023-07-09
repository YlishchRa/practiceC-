using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._9._06._2023
{
    public class APlay : IDisposable
    {
        public string Name { get; set; }
        public string NameOfAuthor { get; set; }
        public string Genre{get;set;}
        public DateOnly year { get; set; }


        public APlay(string name, string nameOfAuthor, string genre, DateOnly year)
        {
            Name = name;
            NameOfAuthor = nameOfAuthor;
            Genre = genre;
            this.year = year;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        ~APlay()
        {

            Name = " ";
            NameOfAuthor = " ";
            Genre = " ";
            year = DateOnly.MinValue;
            Dispose();

        }
    }
}
