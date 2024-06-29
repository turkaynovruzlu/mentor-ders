using System;

namespace mentorders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Vugar";
            //string result = name.Contains("q") ? "Vuqar" : default;
            //Console.WriteLine(result);
            //string text = "turkay";
            ////int b=int.Parse(text);
            //var d = int.TryParse(text, out int c);
            //Console.WriteLine(c);
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(2, 8));
            //Guid guid = Guid.NewGuid();
            //Console.WriteLine(guid.ToString());
            //string random = string.Format("random ededimiz {0}-dir", rnd.Next(2, 8));
            //Console.WriteLine(random);
            //int a = 0;
            //while (a < 10)
            //{
            //    Console.WriteLine(++a);
            //}
            //int i = 9;
            //do
            //{
            //    i++;
            //    Console.WriteLine(i);
            //} while (i < 9);
            int[] arr = new int[9];
            string elemets = default;
            foreach (var elements in arr)
            {
                Console.WriteLine(elements);
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("mentor_lesson");
            }

        }
    }
}
