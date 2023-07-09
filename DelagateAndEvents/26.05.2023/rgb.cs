using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._26._05._2023
{
    public  class rgb
    {
        int[] rgb_color;

        public delegate int[] FindColor(string color);

        public rgb()
        {
            rgb_color = new int[] { 0, 0, 0 };
        }

        public int[] DefineColor(string color, FindColor find)
        {
            rgb_color = find(color);

            return rgb_color;
        }



    }

    //rgb color = new rgb();



    //var a = color.DefineColor("e", delegate (string color)
    //{
    //    int[] rgbColor = new int[] { 0, 0, 0 };
    //    switch (color)
    //    {
    //        case "red":
    //            rgbColor[0] = 255;
    //            rgbColor[1] = 0;
    //            rgbColor[2] = 0;
    //            break;
    //        case "orange":
    //            rgbColor[0] = 255;
    //            rgbColor[1] = 165;
    //            rgbColor[2] = 0;
    //            break;
    //        case "yellow":
    //            rgbColor[0] = 255;
    //            rgbColor[1] = 255;
    //            rgbColor[2] = 0;
    //            break;
    //        case "green":
    //            rgbColor[0] = 0;
    //            rgbColor[1] = 255;
    //            rgbColor[2] = 0;
    //            break;
    //        case "blue":
    //            rgbColor[0] = 0;
    //            rgbColor[1] = 0;
    //            rgbColor[2] = 255;
    //            break;
    //        case "indigo":
    //            rgbColor[0] = 75;
    //            rgbColor[1] = 0;
    //            rgbColor[2] = 130;
    //            break;
    //        case "violet":
    //            rgbColor[0] = 238;
    //            rgbColor[1] = 130;
    //            rgbColor[2] = 238;
    //            break;
    //        default:
    //            Console.WriteLine("Invalid color.");
    //            break;
    //    }
    //    return rgbColor;
    //});

    //Console.WriteLine($"R {a[0]} G {a[1]} B {a[2]}");





}
