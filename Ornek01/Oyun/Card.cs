using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01.Oyun
{
    public class Card
    {
        private string face;
        private string value;

        //setFace: void yani bize kullanılabilir bir bilgi vermeyen sadece işlem yapabilen ve ihtiyaç duyduğu bilgiyi parametre (string face) kullanarak talep bir metotdur.
        public void setFace(string face)
        {
            //this: Bulunduğumuz örneği/instance temsil eder.
            this.face = face;
        }

        //getFace: Dönüş tipi olan yani bize kullanabileceğimiz bir bilgi veren parametre talep etmeyen bir metotdur.
        public string getFace()
        {
            return this.face;
        }

        public string getValue()
        {
            //this yazmaya gerek yok, aynı iğsimde parametre olmadığı için.
            return value;
        }

        //Özel Metotlar:
        //Yapıcı Metot: Nesne new operatörü ile çağırılırken tetiklenen metotdur. Bu metot yazılmazsa boş hali kullanılabilir durumda olur, yoksa üzerine yazılır.
        public Card(string face, string value)
        {
            this.face = face;
            this.value = value;
        }

        //ToString(): Çoğu yapı verileri otomatik olarak bu metodu tetikleyerek string ifadfeye çevirir. Bu metot object temelinden kalıtım olarak gelir. Bu yüzden bu yapıyı kullanmak için override üzerine yazma özelliğini kullanırız.
        public override string ToString()
        {
            //base: Kalıtılan parent (ebeveyn) nesnesine ait mülklere erişmemizi sağlar.
            //return base.ToString();
            return $"| {face} {value} |";
        }
    }
}
