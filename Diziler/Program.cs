using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[] operatörü ile tanımlanırlar. arkasına geldikleri veri tipini kullanarak bir koleksiyon nesnesi oluştururlar.
            /*
             * - Bir sınır olmak zorunda,
             * - Sınırı değiştirmek için nesne yokedilip yeniden tanımlanmalıdır.
             * - Sadece tek tip bir veri tipine ayarlanırlar.
             * - Eleman ekleme veya çıkarma söz konusu değildir. Bulunduğu hücre boşaltılabilir.
             * - new operatörü kullanılarak oluşturalabilir veya başka koleksiyonlardan dönüştürülebilirler.
             * - dizin (index) yapısı kullanırlar, her elemanın dizin numarası bulunur. Bu numara 0'dan başlar, atlama yapılmaz.
             */

            int[] sayilar1 = new int[3];
            sayilar1[0] = 1;
            sayilar1[1] = 7;
            sayilar1[2] = 19;

            for (int i = 0; i < sayilar1.Length; i++)
            {
                Console.WriteLine(sayilar1[i]);
            }

            object[] nesneler = new object[5];
            nesneler[0] = "ilker";
            nesneler[1] = 15.456;
            for (int i = 0; i < nesneler.Length; i++)
            {
                Console.WriteLine(nesneler[i]);
            }

            //Koleksiyonlar: Dizilerden türeyen yapılardır, türlerine göre özellikleri bulunur. Eleman sınırı belirtilmez, ekleme çıkarmaya müsaittir.
            //Koleksiyon uzunluğunu görmek için Count özelliği kullanılır.
            //Dizin (index) özelliği vardır.
            ArrayList arrayList = new ArrayList();

            arrayList.Add("ilker");
            arrayList.Add("turan");
            arrayList.Add(1980);
            arrayList.Add(25.457);
            arrayList.Add(true);
            arrayList.Add(false);
            arrayList.Add('B');

            foreach (object v in arrayList)
            {
                Console.WriteLine($"{v}: {v.GetType()}");
            }
        }
    }
}
