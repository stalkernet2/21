using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Frame
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(Graphic.BorderY(1));



            Console.WriteLine(Graphic.BorderY(-1));
        }
        public static void Session(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("GameDrawed");
            Console.WriteLine(Graphic.ShowCardsOf(player));
            Console.WriteLine(Graphic.ShowCardsOf(opponent)); // debug
        }
        public static void Win(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("Вы выиграли");

            Graphic.DrawEnd(player, opponent);
        }
        public static void Lose(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("Вы проиграли");

            Graphic.DrawEnd(player, opponent);
        }
        public static void Draw(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("Ничья");

            Graphic.DrawEnd(player, opponent);
        }
    }
}
