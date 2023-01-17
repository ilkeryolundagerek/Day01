using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OOP Paradigması için gerekli bir alandır. Hazırlanan nesnel yapı için bir adres tanımı da oluşturur. Nesneleri de gruplar.
namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day02.Program2.DoWork();

            //Veri Tipleri: (İlkel/Primitif ve Referans/Geliştirilmiş)
            //Primitif: Ölçülebilir sistemlerde ortak olarak bulunan, sadece isimleri değişen yapılardır. Sayı temellidirler. Pozitif sayılar 0'dan negatif sayılar -1'den başlar.
            //Tamsayılar:
            byte bayt = 255; //8bit değerindedir. 0 ~ 255
            sbyte isaretli_bayt = 127; //8bit değerindedir. -128 ~ 127

            short kisa = 15000; //16bit değerindedir. -2^15 ~ 2^15-1
            ushort isaretsiz_kisa = 15000; //16bit değerindedir. 0 ~ 2^16-1

            int tam = 15000; //32bit değerindedir. -2^31 ~ 2^31-1
            uint isaretsiz_tam = 15000; //32bit değerindedir. 0 ~ 2^32-1

            long uzun = 15000L; //64bit değerindedir. -2^63 ~ 2^63-1
            ulong isaretsiz_uzun = 15000L; //64bit değerindedir. 0 ~ 2^64-1

            //Floating Point (Gerçel/Reel) Veri Tipleri:
            float tek_duyarli = 3.4e38F; //32bit değerindedir. 
            double cift_duyarli = 1.7e308; //64bit değerindedir.

            //Karakter tipi:
            char karakter = 'İ'; //A = 65 sayısal değerini taşır. UNICODE desteğinden dolayı 16bit alan kaplar.

            //Mantıksal Veri Tipi:
            bool mantiksal = true; //8bit değerindedir. True (1 - 0x00000001), False (0 - 0x00000000)

            //Referans Tipler:
            string karakter_dizisi = "ilker turan"; //Girilen veri seviyesinde yer kaplar.
            decimal ondalik = 14.456M; //128bit değerinde bir yapıdır.

            //Primitif tipler için ek özellikler eklenmesi amacıyla referans verisyonları hazırlanmıştır.
            //short => Int16
            //int => Int32
            //long => Int64
            //float => Single
            Console.WriteLine(karakter_dizisi);

            //object: Bu yapı tüm nesnelerin geldiği veri tipidir. Karşısına eklenen her tipte veriyi kabul eder.
            object nesne = "ilker turan";
        }
    }
}

namespace Day02
{
    public class Program2
    {
        public static void DoWork()
        {
            Car car = new Car();
        }
    }
}
