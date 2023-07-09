using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._25._05._2023
{
    public static class Extensions
    {
        public static bool IsFibonacci(this int number)
        {
            int prev = 0;
            int curr = 1;

            while (curr < number)
            {
                int temp = prev;
                prev = curr;
                curr = temp + curr;
            }

            return curr == number;
        }
        public static int CountWords(this string str)
        {
            string[] l = str.Split(" ");
            return l.Length;
        }
        public static int CountSumbolsInLastWord(this string str)
        {
            string[] l = str.Split(" ");
            int a = l[l.Length - 1].Length;

            return a;

        }
        public static bool ValidStr(this string str)
        {
            if (str.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                    continue;
                }
                if (c == ' ')
                {
                    continue;
                }
                if (c == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static int[] Filter(this int[] numbers, Predicate<int> a)
        {
            int[] result = new int[numbers.Length];
            int j = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (a(numbers[i]))
                {
                    result[j] = numbers[i];
                    j++;
                }
            }
            return result;

            // PUT INTO MAIN FILE
            //int[] numbers = new int[] { 1, 43631, 46, 457, 3, 314, 6, 57, 235 };

            //bool Pred(int a)
            //{
            //    return a % 2 == 0;
            //}

            //int[] n = numbers.Filter(Pred);

            //for (int i = 0; i < n.Length; i++)
            //    Console.WriteLine(n[i] + "\t");
        }
    }

    
}
