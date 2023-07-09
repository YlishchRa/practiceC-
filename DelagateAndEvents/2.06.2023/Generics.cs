using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._2._06._2023
{
    public class Generics
    {
        public static void spaw<T>(T a, T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
    }
    public class pair<T1,T2>
    {
        public T1? key { get; set; }
        public T2? value { get; set; }
        public pair(T1? key, T2? value)
        {
            this.key = key;
            this.value = value;
        }
    }
    public class ValueAndPrioritet<T> 
    {
        public pair<int, T> para;
        public ValueAndPrioritet(T value, int priority)
        {
            para = new pair<int, T>(priority, value);
        }
    }
    public class Queue<T>
    {
        private ValueAndPrioritet<T>[] queue;
        private int maxSize, currentSize;
        public Queue(int maxSize)
        {
            this.maxSize = maxSize;
            queue = new ValueAndPrioritet<T>[maxSize];
            currentSize = 0;
        }
        


        public bool isFull()
        {
            return currentSize - 1 == maxSize;
        }
        public bool isEmpty()
        {
            return currentSize == 0;
        }

        public void Add(T value, int priority)
        {
            //if (isEmpty())
            //{
            //    queue[0] = new ValueAndPrioritet<T>(value, priority);
            //    currentSize++;
            //    return;
            //}
            if (isFull())
            {
                Console.WriteLine("Queue is full");
                throw new OutOfMemoryException();
            }

            ValueAndPrioritet<T> tmp = new ValueAndPrioritet<T>(value, priority);
            int index = 0;

            for (int i = 0; i < currentSize; i++)
            {
                if (tmp.para.key <= queue[i].para.key)
                {
                    index = i+1;
                }
            }



            for (int i = currentSize; i > index; i--)
            {
                queue[i] = queue[i-1];
            }

            currentSize++;
            queue[index] = tmp;
        }

        public T? Pop()
        {
            if (!isEmpty())
            {

                T? result = queue[0].para.value;

                for (int k = 0; k < currentSize-1; k++)
                {
                    queue[k] = queue[k + 1];
                }

                currentSize--;
                return result;
            }

            throw new Exception();
        }


        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < currentSize; i++)
            {
                result += $"Value: {queue[i].para.value}\nPriority: {queue[i].para.key}\n\n";
            }


            return result;
        }
    }


//    DelagateAndEvents._2._06._2023.Queue<string> queue = new DelagateAndEvents._2._06._2023.Queue<string>(10);



//    queue.Add("Ostap", 1);
//queue.Add("Artem", 2);
//queue.Add("yura", 5);
//queue.Add("Sasha", -1);
//queue.Add("Sasha", 20);
//queue.Add("Sasha", -1);
//queue.Add("Sasha", -1);
//queue.Add("Sasha", 5);
//queue.Add("Sasha", 16);
//queue.Add("Sasha", -1);
//queue.Pop();
//queue.Pop();
//queue.Pop();

//Console.WriteLine(queue.ToString());



}
