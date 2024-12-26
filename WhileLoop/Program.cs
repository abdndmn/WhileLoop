// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

namespace WhileLoop
{

    class Program
    {
        static void Main(string[] args)
        {
            //1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Kendime inaniyorum, ben bu yazilim isini hallederim!");
                i++;
            }

            //2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

            int j = 1;
            while (j <= 20)
            {
                Console.WriteLine(j);
                j++;
            }

            //3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            int k = 1;
            while (k <= 20)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);

                }
                k++;
            }

            //4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            int l = 50;
            int sum = 0;
            while (l <= 150)
            {
                sum += l;
                l++;
            }
            Console.WriteLine($"50 ile 150 arasindaki sayilarin toplami {sum}");


            //5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

            int m = 1;
            int sumEven = 0;
            int sumOdd = 0;
            while (m <= 120)
            {

                if (m % 2 == 0)
                {

                    sumEven += m;

                }
                else if (m % 2 == 1)
                {
                    sumOdd += m;
                }
                m++;
            }

            Console.WriteLine($"1 ile 120 arasindaki çift sayilarin toplami {sumEven}");
            Console.WriteLine($"1 ile 120 arasindaki tek sayilarin toplami {sumOdd}");
        }
    }
}
