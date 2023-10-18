using System;
using System.Threading;

namespace HexadecimalDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Шістнадцяткові цифри:");
            Thread thread = new Thread(PrintHexadecimalDigits);
            thread.Start();
        }

        static void PrintHexadecimalDigits()
        {
            for (int i = 0; i < 16; i++)
            {
                if (i < 10)
                {
                    Console.Write(i);
                }
                else
                {
                    char ch = (char)('a' + (i - 10));
                    Console.Write(ch);
                }
                Thread.Sleep(500);
            }
        }
    }
}