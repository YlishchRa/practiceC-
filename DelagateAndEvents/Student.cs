using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace DelagateAndEvents
{
    [Serializable]
    public class Album
    {
        public string name { get; set; }
        public string author { get; set; }
        public DateTime date { get; set; }

        public float len { get; set; }
        public string StudioAudioRecord { get; set; }

        public Album(string name, string author, DateTime date, float len, string studioAudioRecord)
        {
            this.name = name;
            this.author = author;
            this.date = date;
            this.len = len;
            StudioAudioRecord = studioAudioRecord;
        }

        public Album()
        {
            this.name = "";
            this.author = "";
            this.date = DateTime.MinValue;
            this.len = 0;
            StudioAudioRecord = "";
        }

        public void EnterData()
        {
            Console.WriteLine("Enter name of album: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter author of album: ");
            author = Console.ReadLine();
            Console.WriteLine("Enter date of album: ");
            date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter length of album");
            len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Studio Audio Record of album");
            StudioAudioRecord = Console.ReadLine();
        }

        public void SearializeObject(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Album));

            try
            {
                using (Stream stream = File.Create(path + @"/test.xml"))
                {
                    xml.Serialize(stream, this);
                }
                Console.WriteLine("Seccssesfully serialized and saved");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Album DeserializeObject(string path)
        {
            Album? al = null;
            XmlSerializer xml = new XmlSerializer(typeof(Album));
            try
            {
                using (Stream stream = File.OpenRead(path + @"/test.xml"))
                {
                   al = (Album)xml.Deserialize(stream);
                }
                Console.WriteLine("Seccssesfully deserialized");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return al;
        }


        public string ToString()
        {
            return $" Name: {name} \n Author: {author}\n Date{date}\n Lenght{len}\n Studio audio record{StudioAudioRecord}\n";
        }

    }

}
