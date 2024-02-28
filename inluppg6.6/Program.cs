using System;

namespace inluppg6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en text");
            string inputString = Console.ReadLine();
            OmvandlaVartannat(inputString);
        }

        static void OmvandlaVartannat(string inputString)
        {
            string[] splitString = inputString.Split(' ');
            for (int i = 0; i <splitString.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(splitString[i].ToUpper() + ' ');
                }
                else
                {
                    Console.Write(splitString[i] + ' ');
                }
            }
        }
    }
}