using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Frame
    {
        private static Action[] actions = { InMenu, Help, InGame };
        public static int Index = 0;
        public static void Draw()
        {
            actions[Index].Invoke();
        }

        private static void InMenu()
        {
            Console.Clear();
            Console.WriteLine(Graphic.BorderY(1));

            Menu.ChooseIndex();

            Console.WriteLine(Graphic.BorderY(-1));
        }
        private static void InGame()
        {
            Console.Clear();
            Console.WriteLine("GameDrawed");
            Console.WriteLine(Graphic.ShowCardsOf(Game.Player.Cards));
            Console.WriteLine(Graphic.ShowCardsOf(Game.Opponent.Cards)); // debug
        }
        public static void Help()
        {
            Console.Clear();
            Console.WriteLine("Здесь, покачто, ничего нету");
        }
        public static void DrawEnd(string text)
        {
            Console.Clear();
            Console.WriteLine(text);
            Console.WriteLine("Ваши карты");
            Console.WriteLine(Graphic.ShowCardsOf(Game.Player.Cards));
            Console.WriteLine("Карты опонента");
            Console.WriteLine(Graphic.ShowCardsOf(Game.Opponent.Cards));
            Index = (int)Player.In.Menu;
            Console.ReadKey();
        }
    }
}
