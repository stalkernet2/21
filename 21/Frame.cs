using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Frame
    {
        public static void Main1()
        {
            Console.Clear();
            Console.WriteLine(Graphic.BorderY(1));

            Menu.ChooseIndex();

            Console.WriteLine(Graphic.BorderY(-1));
        }
        public static void InGame(int[] player, int[] opponent)
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

            DrawEnd(player, opponent);
        }
        public static void Lose(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("Вы проиграли");

            DrawEnd(player, opponent);
        }
        public static void Draw(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("Ничья");

            DrawEnd(player, opponent);
        }
        public static void Help()
        {
            Console.WriteLine("Здесь, покачто, ничего нету");
        }
        private static void DrawEnd(int[] player, int[] opponent)
        {
            Console.WriteLine("Ваши карты");
            Console.WriteLine(Graphic.ShowCardsOf(player));
            Console.WriteLine("Карты опонента");
            Console.WriteLine(Graphic.ShowCardsOf(opponent));
            Game.GameStart = false;
            Console.ReadKey();
        }
    }
}
