using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryGoster
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi=0;
            Console.WriteLine("0-255 arasinda bir deger giriniz:");
            sayi = Convert.ToByte(Console.ReadLine());
            if (sayi >= 0 && sayi <= 255)
            {
                for (byte j = 8; j >= 1; j--)
                {
                    byte and = 1;
                    for (byte k = 1; k <= j - 1; k++)
                    {
                        and *= 2;
                    }

                    byte bit = (byte)((sayi & and) >> j - 1);
                    Console.Write(bit);


                }

            }
            else Console.WriteLine("Hatalı giris !");

        }
    }
}
