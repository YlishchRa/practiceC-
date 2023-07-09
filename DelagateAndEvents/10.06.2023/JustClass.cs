using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._10._06._2023
{
    public class JustClass
    {

        public void main()
        {
            int[] numbers = new int[100];

            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = rand.Next(0, 100);
            }
            using (StreamWriter writer = new StreamWriter("SimpleNumbers.txt", false))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (IsPrime(numbers[i]))
                    {
                        writer.WriteLine(numbers[i]);
                    }
                }

            }
            using (StreamWriter writer = new StreamWriter("Fibon.txt", false))
            {

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (IsFibonacciNumber(numbers[i]))
                        writer.WriteLine(numbers[i]);
                }

            }


            using (StreamReader reader = new StreamReader("SimpleNumbers.txt"))
            {
                string line;

                Console.WriteLine("Simle numbers: ");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            using (StreamReader reader = new StreamReader("Fibon.txt"))
            {
                string line;

                Console.WriteLine("Fibon numbers: ");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
        static bool IsFibonacciNumber(int number)
        {
            if (number == 0 || number == 1)
                return true;

            int prev = 0;
            int curr = 1;

            while (curr <= number)
            {
                int temp = curr;
                curr = prev + curr;
                prev = temp;

                if (curr == number)
                    return true;
            }

            return false;
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }



        public void moderation()
        {
            string anmin_path = $@"admin_word.txt";
            Console.WriteLine("Enter name of file");
            string use_path = $@"{Console.ReadLine()}.txt";

            string[] admin_word = new string[0];
            string[] user_word = new string[0];

            using(StreamReader admin_reader = new StreamReader(anmin_path))
            {
                string[] tmp_words = admin_reader.ReadToEnd().ToLower().Split(' ');
                admin_word = tmp_words;
            }

            using (StreamReader user_reader = new StreamReader(use_path))
            {
                string[] tmp_words = user_reader.ReadToEnd().ToLower().Split(' ');
                user_word = tmp_words;
            }


            for(int i = 0; i < user_word.Length;i++)
            {
                for(int j =0; j < admin_word.Length; j++)
                {
                    if (user_word[i] == admin_word[j])
                    {

                        for(int k = 0; k < user_word[i].Length; k++)
                        {
                            user_word[i] = user_word[i].Replace(user_word[i][k], '*');
                        }

                        
                    }
                }
            }
            string path = "other.txt";
            using(StreamWriter user_witer = new StreamWriter(path, false))
            {
                foreach(string word in user_word)
                {
                    user_witer.Write($"{word}\t");
                }
            }


        }
    }
}






