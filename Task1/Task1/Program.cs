using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 9, -5, 0, 76, 34, 6, -18 };
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Arrayin en kicik elementi:" + min);
        }
    }
}
