using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngü (loop): Belitilen mantıksal ifade sağlandığı sürece ilgili kod bloğunu tekrarlı olarak işletir.

            //for: Bağlı koşulun sağlamasını bozmak amacıyla kumülatif işlem kullanan bir döngü tipidir.
            //Sonsuz/Kısır şablunu: for(;;){}

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i: {i}");
            }


            for (int j = 0; ; j++)
            {
                if (j < 10)
                {
                    Console.WriteLine($"j: {j}");
                }
                else
                {
                    break;//ilgili ilk döngü parantezini sonlandırır.
                }
            }
            Console.WriteLine();
            //while, do...while: Genellikle sınırı bilinmeyen kaynaklar için kullanılır.
            int sayi = 1589675876;

            while (sayi > 0)
            {
                Console.WriteLine(sayi % 10); //Herhangi bir sayının birler basamağını verir.
                sayi /= 10;//Herhangi bir tam sayının birler basamağını atmak için kullanılır.
            }
            Console.WriteLine();
            sayi = 2138796525;

            do//En az bir kere kodun işletilmesi gerektiği zamanlarda kullanılır.
            {
                Console.WriteLine(sayi % 10); //Herhangi bir sayının birler basamağını verir.
                sayi /= 10;//Herhangi bir tam sayının birler basamağını atmak için kullanılır.
            } while (sayi>0);
        }
    }
}
