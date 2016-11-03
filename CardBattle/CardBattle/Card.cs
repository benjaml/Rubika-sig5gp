using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle
{
    class Card
    {
        public VALUE _number { get; set; }
        public COLORENUM _color { get; set; }

        public Card(VALUE number, COLORENUM color)
        {
            _number = number;
            _color = color;
        }

        public override string ToString()
        {
            string ret = "";
            ret += _number;
            ret += " of ";
            ret += _color;
            return ret;
        }
    }
}
