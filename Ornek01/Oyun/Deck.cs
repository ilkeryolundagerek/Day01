using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01.Oyun
{
    public class Deck
    {
        //List<T>: Generic bir koleksiyondur, T (strong type/baskın tip)'nin yerine istediğimiz class'ı yazarak kullanılır. Koleksiyon T'nin yerine geçen sınıfa uygun olarak düzenlenir.
        //Bu bir Card sınıfı koleksiyonudur.
        private List<Card> Cards;

        public Deck()
        {
            //Koleksiyonlar her zaman ilk önce new operatörü ile veya başka bir koleksiyon ile oluşturulmalıdır.
            Cards = new List<Card>();
            string[] faces = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (var face in faces)
            {
                foreach (var value in values)
                {
                    Card temp = new Card(face, value);
                    Cards.Add(temp);
                }
            }
        }

        public List<Card> GetCards(int card_count)
        {
            //Take: System.Linq kütüphanesi sayesinden koleksiyonların içinden ilk istenilen eleman kadarını çekmemizi sağlar. Fakat o elemanları listeden atmaz.
            //ToList(): List sınıfından gelmeyen koleksiyonları listeye dönüştürür.
            List<Card> result = Cards.Take(card_count).ToList();
            Cards.RemoveRange(0, card_count);
            return result;
        }

        public override string ToString()
        {
            //string.Join(): Belirlenen ayraç kullanılarak belirtilen koleksiyon elemanları string ifadeye dönüştürülür. Elemanlar ToString metodu kullanılarak dönüştürülür.
            return string.Join(", ", Cards);
        }
    }
}
