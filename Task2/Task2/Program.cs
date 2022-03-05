using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Metni daxil edin");
            text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++ )
            {
                if (text [i] =='a')
                {
                    Console.WriteLine("Metnde a simvolu var");
                    break;
                }
                else
                {
                    Console.WriteLine("Metnde a simvolu yoxdur");
                    continue;
                }
                
            }
            


        }
    }
}
