using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            bool simvol=false;
            Console.WriteLine("Metni daxil edin");
            text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    simvol = true;
                    break;
                }
            }
            Console.WriteLine(simvol);
        }
    }
}