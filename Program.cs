using System;
using System.Collections.Generic;


namespace Myapp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Jacob");
            names.Add("Sue");
            
            names.ForEach(name => Console.Write(name + " "));

            string aString = "a";
            List<string> stuff = new List<string> { aString, "b", "c", "d"};
            stuff.ForEach(stuff => Console.WriteLine(stuff));

            char aSingelCharacter = 'a';
            Console.WriteLine($"This is a single character: {aSingelCharacter}");             

            int x = 5;
            int y = 7;
            int result = Adder(x, y);

            int result2 = Adder(10, 46);

            Console.WriteLine($"{x} + {y} = {result}");
        }

        static int Adder(int a, int b)
        {
            return a + b;
        }
    }
}


