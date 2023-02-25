using System;

namespace ifelsehometask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int mebleg = 100;
         
if (mebleg < 100)
            {
                int odenilecek = (mebleg - ((mebleg / 100) * 5));
    Console.WriteLine(odenilecek);

            }
            else if (100 <= mebleg && mebleg <= 1000)
            {
                int odenilecek = (mebleg - ((mebleg / 100) * 8));
                Console.WriteLine(odenilecek);
            }
            else if (1000 < mebleg)
            {
                int odenilecek = (mebleg - ((mebleg / 100) * 10));
                Console.WriteLine(odenilecek);
            }
            else
            {
                Console.WriteLine("I don't know");
            }
        }
    }
}