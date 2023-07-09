using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._26._05._2023
{
    public class backpack
    {

        public delegate void AddItemDelegate(char item, EventArgs e);
        public event AddItemDelegate AddItem;
        rgb color;
        KeyValuePair<string , string> mark;
        string cloth;
        int weight;
        int currentvolime;
        int maxVolume;
        public List<List<char>> items { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public backpack(rgb color, KeyValuePair<string, string> mark, string cloth, int weight, int maxVolume)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            currentvolime = 0;
            this.color = color;
            this.mark = mark;
            this.cloth = cloth;
            this.weight = weight;
            this.maxVolume = maxVolume;
            items = new List<List<char>>();
            
            for(int i = 0; i < maxVolume; i++)
            {
                items.Add(new List<char>());
                for (int j = 0; j < maxVolume; j++)
                {
                    items[i].Add(' ');
                }
            }
            //BasedAdd(' ');
        }
        private void BasedAdd(char item)
        {
            if (AddItem != null)
            {
                EventArgs e = new EventArgs();
                AddItem += delegate (char item, EventArgs e)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        for(int j = 0; j < items[i].Count; j++)
                        {
                            items[i][j] = item;
                        }
                    }

                };
                AddItem(item, e);
            }
        }
        public void Add(char item, int weight)
        {
            if(currentvolime + weight > maxVolume)
            {
                throw new OutOfMemoryException();
            }

            if(AddItem != null)
            {
                EventArgs e = new EventArgs();
                AddItem(item, e);
            }
        }
        public override string  ToString() 
        {
            string res = "";

            foreach (var line in items)
            {
                foreach (char item in line)
                {
                    res += item;
                }
                res += "\n";
            }

            return res;
        }
    }

//    backpack bp = new backpack(new rgb(), new KeyValuePair<string, string>("Addidas", "China"), "Len", 3, 10);


//    bp.AddItem += delegate (char item, EventArgs e)
//{
//    bp.items[0].Insert(0, item);
//};

//bp.Add('S', 1);
//bp.Add('S', 1);
//bp.Add('T', 1);
//bp.Add('B', 1);
//bp.Add('E', 1);
//bp.Add('S', 1);
//bp.Add('S', 1);
//bp.Add('T', 1);
//bp.Add('B', 1);
//bp.Add('E', 1);
//bp.Add('E', 1);
//bp.Add('K', 1);


//Console.WriteLine(bp.ToString());

}
