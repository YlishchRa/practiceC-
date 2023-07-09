using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._27._04._2023
{

    public enum Lenguage
    {
        Morze,
        English
    }

    public class Switcher
    {
        public string Switch(string message, Lenguage mode)
        {
            string result = "";
            if(mode == Lenguage.Morze)
            {
                for(int i = 0; i < message.Length; i++)
                {
                    result += FindSymbolInMorze(message[i]);
                }
            }
            if (mode == Lenguage.English)
            {
                string[] morze = message.Split(" ");

                for(int i = 0; i < morze.Length; i++)
                {
                    result += FindSumbolInHumnlanguage(morze[i]);
                }
            }
            return result;
        }

        public string FindSymbolInMorze(char symbol)
        {
            if(symbol == 'A' || symbol == 'a')
            {
                return " *-";
            }
            if (symbol == 'B' || symbol == 'b')
            {
                return " -***";
            }
            if (symbol == 'C' || symbol == 'c')
            {
                return " -*-*";
            }
            if (symbol == 'D' || symbol == 'd')
            {
                return " -**";
            }
            if (symbol == 'E' || symbol == 'e')
            {
                return " *";
            }
            if (symbol == 'F' || symbol == 'f')
            {
                return " **-*";
            }
            if (symbol == 'G' || symbol == 'g')
            {
                return " --*";
            }
            if (symbol == 'H' || symbol == 'h')
            {
                return " ****";
            }
            if (symbol == 'I' || symbol == 'i')
            {
                return " **";
            }
            if (symbol == 'J' || symbol == 'j')
            {
                return " *---";
            }
            if (symbol == 'K' || symbol == 'k')
            {
                return " -*-";
            }
            if (symbol == 'L' || symbol == 'l')
            {
                return " *-**";
            }
            if (symbol == 'M' || symbol == 'm')
            {
                return " --";
            }
            if (symbol == 'N' || symbol == 'n')
            {
                return " -*";
            }
            if (symbol == 'O' || symbol == 'o')
            {
                return " ---";
            }
            if (symbol == 'P' || symbol == 'p')
            {
                return " *--*";
            }
            if (symbol == 'Q' || symbol == 'q')
            {
                return " --*-";
            }
            if (symbol == 'R' || symbol == 'r')
            {
                return " *-*";
            }
            if (symbol == 'S' || symbol == 's')
            {
                return " ***";
            }
            if (symbol == 'T' || symbol == 't')
            {
                return " -";
            }
            if (symbol == 'U' || symbol == 'u')
            {
                return " **-";
            }
            if (symbol == 'V' || symbol == 'v')
            {
                return " ***-";
            }
            if (symbol == 'W' || symbol == 'w')
            {
                return " *--";
            }
            if (symbol == 'X' || symbol == 'x')
            {
                return " -**-";
            }
            if (symbol == 'Y' || symbol == 'y')
            {
                return " -*--";
            }
            if (symbol == 'Z' || symbol == 'z')
            {
                return " --**";
            }
            if (symbol == '0')
            {
                return " -----";
            }
            if (symbol == '1')
            {
                return " *----";
            }
            if (symbol == '2' )
            {
                return " **---";
            }
            if (symbol == '3')
            {
                return " ***--";
            }
            if (symbol == '4' )
            {
                return " ****-";
            }
            if (symbol == '5' )
            {
                return " *****";
            }
            if (symbol == '6' )
            {
                return " -****";
            }
            if (symbol == '7' )
            {
                return " --***";
            }
            if (symbol == '8' )
            {
                return " ---**";
            }
            if (symbol == '9')
            {
                return " ----*";
            }
            return "";
        }
        public string FindSumbolInHumnlanguage(string message)
        {
            if(message == " ")
            {
                return " ";
            }
            if (message == "*-")
            {
                return "A";
            }
            if (message == "-***")
            {
                return "B";
            }
            if (message == "-*-*")
            {
                return "C";
            }
            if (message == "-**")
            {
                return "D";
            }
            if (message == "*")
            {
                return "E";
            }
            if (message == "**-*")
            {
                return "F";
            }
            if (message == "--*")
            {
                return "G";
            }
            if (message == "****")
            {
                return "H";
            }
            if (message == "**")
            {
                return "I";
            }
            if (message == "*---")
            {
                return "J";
            }
            if (message == "-*-")
            {
                return "K";
            }
            if (message == "*-**")
            {
                return "L";
            }
            if (message == "--")
            {
                return "M";
            }
            if (message == "-*")
            {
                return "N";
            }
            if (message == "---")
            {
                return "O";
            }
            if (message == "*--*")
            {
                return "P";
            }
            if (message == "--*-")
            {
                return "Q";
            }
            if (message== "*-*")
            {
                return "R";
            }
            if (message == "***")
            {
                return "S";
            }
            if (message == "-")
            {
                return "T";
            }
            if (message == "**-")
            {
                return "U";
            }
            if (message == "***-")
            {
                return "V";
            }
            if (message == "*--")
            {
                return "W";
            }
            if (message == "-**-")
            {
                return "X";
            }
            if (message == "-*--")
            {
                return "Y";
            }
            if (message == "--**")
            {
                return "Z";
            }
            if (message == "-----")
            {
                return "0";
            }
            if (message == "*----")
            {
                return "1";
            }
            if (message == "**---")
            {
                return "2";
            }
            if (message == "***--")
            {
                return "3";
            }
            if (message == "****-")
            {
                return "4";
            }
            if (message == "*****")
            {
                return "5";
            }
            if (message == "-****" )
            {
                return "-****";
            }
            if (message == "--***")
            {
                return "7";
            }
            if (message == "---**")
            {
                return "8";
            }
            if (message == "----*")
            {
                return "9";
            }
            return "";
        }
    }


}
