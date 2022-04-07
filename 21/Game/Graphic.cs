﻿using System.Text;

namespace _21
{
    public class Graphic
    {
        private static readonly int BorderSize = 3;
        private static readonly char[] BorderChars = new char[4] { '\u2588', '\u2593', '\u2592', '\u2591' };

        public static string ShowCardsOf(int[] cards)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == 0)
                    sb.Append("  ");
                else if (i < cards.Length - 1)
                    sb.Append(cards[i] + " ");
                else
                    sb.Append(cards[i]);
            }
            return sb.ToString();
        }

        public static void ColorText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static string Border(int offset)
        {

            StringBuilder borderLine = new StringBuilder();

            for (int i = 0; i < BorderSize; i++)
            {
                for (int j = 0; j < Console.WindowWidth - 1; j++)
                {
                    borderLine.Append(BorderChars[i]);
                }
                if (i != BorderSize - 1)
                {
                    borderLine.Append('\n');
                }
            }

            switch (offset)
            {
                case 1:
                    return borderLine.ToString();
                case -1:
                    return TrueReverse(borderLine);
                default:
                    throw new Exception();
            }
        }

        public static string ToCenterX(string offsetText)
        {
            int spaceLength = (Console.WindowWidth - offsetText.Length) / 2 - 2;
            string space = "";
            for (int i = 0; i <= spaceLength; i++)
            {
                space += " ";
            }
            return space + offsetText + space;
        }
        public static void ToCenterY(int offset)
        {
            for (int j = 0; j < Console.WindowHeight / 2 - (offset - 2) - 4; j++)
            {
                Console.WriteLine();
            }
        }
        public static string ToSide(string text)
        {
            int spaceLength = (Console.WindowWidth - text.Length) / 2 - 2;
            string space = "";
            for (int i = 0; i <= spaceLength; i++)
            {
                space += " ";
            }
            return space;
        }

        private static string TrueReverse(StringBuilder text)
        {
            char[] reverseChar = text.ToString().Reverse().ToArray();
            return new string(reverseChar);
        }
    }
}