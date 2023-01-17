using Ornek01.Oyun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card sinek2 = new Card("Sinek", "2");
            Console.WriteLine(sinek2);
            Console.WriteLine(sinek2.getFace());

            Console.WriteLine();

            Deck deck = new Deck();
            Console.WriteLine(deck);
            Console.WriteLine(deck.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(string.Join(", ",deck.GetCards(4)));
            Console.WriteLine(string.Join(", ",deck.GetCards(4)));
            Console.WriteLine(string.Join(", ",deck.GetCards(4)));
            Console.WriteLine();
            Console.WriteLine(deck);
            Console.WriteLine(deck.GetHashCode());
        }
    }
}
