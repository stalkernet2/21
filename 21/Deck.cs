using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Deck
    {
        public static int[,] Cards = new int[,]{{ 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 },
                                                { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 },
                                                { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 },
                                                { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 }};

        public static int CardsLength = Cards.Length / 4;
    }
}
