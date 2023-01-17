using Nesneler2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Concrate nesneler:
            Kutu KutuA = new Kutu(); //KutuA, Kutu sınıfının instance (örneği) dir.
            KutuA.en = 5;
            KutuA.boy = 3;
            KutuA.yukseklik = 4;
            KutuA.CevreHesapla();
            KutuA.HacimHesapla();
            Kutu KutuB = new Kutu();
            Kutu KutuC = new Kutu();

            Nesneler2.Kavanoz kavanoz = new Nesneler2.Kavanoz();
        }
    }

    //Object (nesne): Özellikleri olan, tanımları yapılmış yapılardır. Kullanım alanlarına göre ayrılırlar.
    //Class (Sınıf): Bu nesnelerin amacı bilgiyi sınıflandırmaktır. İçinde bulunan işlevsel (method) ve değişken mülklerle (property/field/attribute) tanımlanırlar.abstract ve concerate ikiye ayrılır.
    //Enum (Sıralanmış/Numaralandırılmış):

    //Erişim Belirleyiciler:
    //Nesne türlerli erişim belirleyici ya yazılmaz yada public veya internal yazılır.
    //public: Nesnenin erişimini her yere açar, bu sayede nesne üretilebilir ve kullanılabilir.
    //internal veya boş: Aynı asembly içerisinde erişim sağlar.
    class Kutu
    {
        //private: Mülkler için kullanılır. Sadece nesne içerisinde erişilebilen yapılar içindir, dışarıdan erişim olmaz. Kalıtımla aktarılmaz.
        private string isim;

        //protected: Sınfın kendisi ve o sınıfı kalıtım alan diğer alt sınıflar için tanımlanır.
        protected string soyisim;

        //Değişken mülkler (property/field/attribute):
        public int boy;
        public int en;
        public int yukseklik;

        //İşlevsel mülkler (method):
        public void HacimHesapla()
        {
            isim = "İlker";
            Console.WriteLine(en * boy * yukseklik);
            Kavanoz kavanoz = new Kavanoz();
        }

        public void CevreHesapla()
        {
            Console.WriteLine(4 * (en + boy + yukseklik));
        }
    }

}
