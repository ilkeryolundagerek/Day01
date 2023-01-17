using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atama operatörü (=):
            double sayi1 = 15;
            double sayi2 = 35;
            double sayi3 = sayi1;
            sayi1 = sayi2;

            //Aritmetik (+,-,/,*,%,++,--,+=,-=,/=,*=,%=):
            //Bölme işlemi iki tamsayı veri tipiyle yapılırsa sonuç tam çıkar.

            Console.WriteLine(++sayi1);//Önce arttırır sonra satırı işletir.
            Console.WriteLine(sayi1++);//Önce satırı işletir sonra arttırır.
            Console.WriteLine(--sayi1);//Önce azaltır sonra satırı işletir.
            Console.WriteLine(sayi1--);//Önce satırı işletir sonra arttırır.
            Console.WriteLine();

            Console.WriteLine($"Başlangıç değeri: {sayi1}");
            sayi1 += 4;//sayi1 = sayi1 + 4
            Console.WriteLine("sayi1 += 4: " + sayi1);
            sayi1 -= 7;//sayi1 = sayi1 - 7
            Console.WriteLine("sayi1 -= 7: {0}", sayi1);
            sayi1 *= 3;//sayi1 = sayi1 * 3
            Console.WriteLine($"sayi1 *= 3: {sayi1}");
            sayi1 /= 2;//sayi1 = sayi1 / 2
            Console.WriteLine($"sayi1 /= 2: {sayi1}");
            sayi1 %= 5;//sayi1 = sayi1 % 5
            Console.WriteLine($"sayi1 %= 5: {sayi1}");
            Console.WriteLine();
            //Mantıksal Operatörler (&&: And, ||: Or, !: Not, &=, |=)
            bool bit1 = true;
            bool bit2 = false;
            //AND (&&): Giren iki mantıksal operantın değerlerini karşılaştırarak Ve işlemine tabi tutar. Giren değerlerden biri False ise sonuç False çıkar.
            /*
             * TRUE && TRUE => TRUE
             * FALSE && TRUE => FALSE
             * TRUE && FALSE => FALSE
             * FALSE && FALSE => FALSE
             */
            Console.WriteLine($"bit1({bit1}) && bit2({bit2}) = {bit1 && bit2}");

            //OR (||): Giren iki mantıksal operantın değerlerini karşılaştırarak Veya işlemine tabi tutar. Giren değerlerden biri True ise sonuç True çıkar.
            /*
             * TRUE || TRUE => TRUE
             * FALSE || TRUE => TRUE
             * TRUE || FALSE => TRUE
             * FALSE || FALSE => FALSE
             */
            Console.WriteLine($"bit1({bit1}) || bit2({bit2}) = {bit1 || bit2}");

            //NOT (!): Değil işlemidir, önüne geldiği mantıksal operantı tersler.
            /*
             * !TRUE => FALSE
             * !FALSE => TRUE
             */
            Console.WriteLine($"!bit1({bit1}) = {!bit1}");
            Console.WriteLine($"!bit2({bit2}) = {!bit2}");

            bool bit3 = true;
            bool bit4 = false;
            bool bit5 = true;

            bit5 &= bit1;//bit5 = bit5 && bit1
            Console.WriteLine($"bit5({bit5}) &= bit1({bit1}) => {bit5}");
            bit5 |= bit2;//bit5 = bit5 || bit2
            Console.WriteLine($"bit5({bit5}) |= bit2({bit2}) => {bit5}");
            bit5 |= bit3;//bit5 = bit5 || bit3
            Console.WriteLine($"bit5({bit5}) |= bit3({bit3}) => {bit5}");
            bit5 &= bit4;//bit5 = bit5 && bit4
            Console.WriteLine($"bit5({bit5}) &= bit4({bit4}) => {bit5}");

            //Koşul (Ternary) Operatörü (?:): en az biri mantıksal 3 operant girer, mantıksal operantın durumuna göre diğer iki operanttan birinin atamasını yapar.  Karar mekanızmaları (if,else,switch) bu yapıdan türetilmiştir.
            double buyuk = sayi1 > sayi2 ? sayi1 : sayi2;

            //Karşılaştırma Operatörleri (<,>,<=,>=,==,!=):
            Console.WriteLine($"{sayi1} > {sayi2} = {sayi1 > sayi2}");
            Console.WriteLine($"{sayi1} < {sayi2} = {sayi1 < sayi2}");
            Console.WriteLine($"{sayi1} >= {sayi2} = {sayi1 >= sayi2}");
            Console.WriteLine($"{sayi1} <= {sayi2} = {sayi1 <= sayi2}");
            Console.WriteLine($"{sayi1} == {sayi2} = {sayi1 == sayi2}");
            Console.WriteLine($"{sayi1} != {sayi2} = {sayi1 != sayi2}");

        }
    }
}
