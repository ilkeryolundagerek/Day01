using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararVerme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IF (EĞER): Girilen mantıksal koşul ifadesine göre sadece True cevabı sırasında işlemler uygulayabilir.

            int sayi1 = 25;
            int sayi2 = 25;

            if (sayi1 > sayi2)
            {
                Console.WriteLine($"sayi1({sayi1}) büyüktür sayi2({sayi2})'den");
            }

            //IF...ELSE (EĞER...DEĞİLSE): Bir mantıksal koşul ifadesinin her iki durumu içinde ayrı işlemler uygulanabilir.
            if (sayi1 > sayi2)
            {
                Console.WriteLine($"sayi1({sayi1}) büyüktür sayi2({sayi2})'den");
            }
            else //if yapısının kontrol ettiği sınırların dışında kalan her türlü durum için kod yazılır.
            {
                Console.WriteLine($"sayi1({sayi1}) büyük değildir sayi2({sayi2})'den");
            }

            //IF...ELSE IF...ELSE: Girilen koşul ifadelerinin her bir adımının True durumları için ilgili kodlar, bütün ifadelerin sağlanmadığı (False) durumsa ise else bloğu uygulanabilir.
            if (sayi1 > sayi2) //İlk kontrol noktası
            {
                Console.WriteLine($"sayi1({sayi1}) büyüktür sayi2({sayi2})'den");
            }
            else if (sayi1 < sayi2) //ikinci kontrol noktası
            {
                Console.WriteLine($"sayi1({sayi1}) küçüktür sayi2({sayi2})'den");
            }
            else //Girilen koşulların hiçbiri sağlanamadıysa bu kısım işletilir.
            {
                Console.WriteLine($"sayi1({sayi1}) eşittir sayi2({sayi2})");
            }

            int gun = 4;

            if (gun == 1)
            {
                Console.WriteLine("Pazartesi");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Salı");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Çarşamba");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Perşembe");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Cuma");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cumartesi");
            }
            else if (gun == 7)
            {
                Console.WriteLine("Pazar");
            }
            else
            {
                Console.WriteLine("Böyle bir gün yok.");
            }

            //SWITCH: Girilen temel bir değerin farklı fazlardaki eşilik durumları takip etmek için kullanılır. Her durum için fazladan bir mantıksal ifade ekleyebiliriz, bunun için durum bilgisinden hemen sonra when eklenir.
            int deger = 60;
            bool work = false;
            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;//switch parantezini sonlandırır. Olmaması durumunda case durumlarını birleştirmek için kullanırız.
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4 when deger > 50 & work: 
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Böyle bir gün yok.");
                    break;
            }

            Gunler gunler = Gunler.Pazartesi;

            switch (gunler)
            {
                case Gunler.Pazartesi:
                    break;
                case Gunler.Sali:
                    break;
                case Gunler.Carsamba:
                    break;
                case Gunler.Persembe:
                    break;
                case Gunler.Cuma:
                    break;
                case Gunler.Cumartesi:
                    break;
                case Gunler.Pazar:
                    break;
            }


        }
    }
}
