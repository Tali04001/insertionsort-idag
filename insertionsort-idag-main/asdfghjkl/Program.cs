using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asdfghjkl
{
    class Program
    {
        static void InsertionSort(int[] data)
        {
            
            for (int i = 1; i < data.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    
                    if (data[j] < data[j - 1])
                    {
                        int tmp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = tmp;
                    }
                    else
                        break;
                }
            }
        }

        static int[] GenerateData(int size)
        {
            Random rnd = new Random();
            int[] data = new int[size];

            for (int i = 0; i < data.Length; i++)
                data[i] = rnd.Next(data.Length);

            return data;
        }

        static void Main(string[] args)
        {
            int[] sizes = new int[] { 1000 , 2000, 4000, 8000 };

            for (int i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine("Skapar slumpad data av längd " + sizes[i]);
                int[] data = GenerateData(sizes[i]);

                Console.WriteLine("Sorterar slumpad data");
                DateTime startTid = DateTime.Now;
                InsertionSort(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera.\n", deltaTid.TotalMilliseconds);

                Console.WriteLine("Sorterar redan sorterad data");
                startTid = DateTime.Now;
       
            }

        }
    }
}