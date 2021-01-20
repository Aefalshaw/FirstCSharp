using System;

using System.Collections.Generic;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            foreach (int num in numArray)
            {
                Console.WriteLine(num);
            }

            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }



            bool[] array = new bool[10];          
            for (int i = 0; i < array.Length; i++) 
                {
                    if (i % 2 == 0) 
                    {
                        array[i] = true;
                    }
                    Console.WriteLine(array[i]);
                }
            



            List<string> iceCreams = new List<string>();
            iceCreams.Add("Chocolate");
            iceCreams.Add("Vanilla");
            iceCreams.Add("Strawberry");
            iceCreams.Add("Swirl");
            iceCreams.Add("Shorbet");
            for(var idx = 0; idx < iceCreams.Count; idx++)
            {
                Console.WriteLine(iceCreams[idx]);
            }
            Console.WriteLine(iceCreams.Count);
            Console.WriteLine(iceCreams[2]);
            iceCreams.RemoveAt(2);
            Console.WriteLine(iceCreams.Count);
        
        
        
            Dictionary<string,string> people = new Dictionary<string,string>();
            people.Add("Tim", null);
            people.Add("Martin", null);
            people.Add("Nikki", null);
            people.Add("Sara", null);

            Random flavor = new Random();
            people["Tim"] = iceCreams[flavor.Next(iceCreams.Count)];
            people["Martin"] = iceCreams[flavor.Next(iceCreams.Count)];
            people["Nikki"] = iceCreams[flavor.Next(iceCreams.Count)];
            people["Sara"] = iceCreams[flavor.Next(iceCreams.Count)];
            
            foreach (var entry in people)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}

