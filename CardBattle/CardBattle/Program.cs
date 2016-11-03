using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Card test = new Card(VALUE.ACE, COLORENUM.DIAMOND);

            Console.WriteLine("I created a card : " + test);

            Console.ReadLine();
        }
    }
}
