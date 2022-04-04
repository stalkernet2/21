using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Menu
    {
        private static int index = 0;
        private static readonly string[] MenuText = { "Начать игру", "Помощь", "Выход" };
        private static readonly Action[] actions = { Play, Help, Exit };
        public static int Index
        {
            get 
            { 
                return index; 
            }
            set 
            { 
                if(index + value >= 0 && index + value <= MenuText.Length)
                {
                    index = value;
                }
                else
                {
                    if(index + value > MenuText.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index = MenuText.Length - 1;
                    }
                }
            }
        }

        public static void ChooseIndex()
        {
            for (int i = 0; i < MenuText.Length; i++)
            {
                if(i == 0)
                {
                    Graphic.ToCenterY(MenuText.Length);
                }
                if(i != index)
                {
                    Console.WriteLine(Graphic.ToCenterX(MenuText[i]));
                }
                else
                {
                    Console.Write(Graphic.ToSide(MenuText[i]));
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(MenuText[i]);
                    Console.ResetColor();
                    Console.WriteLine(Graphic.ToSide(MenuText[i]));
                }
                if(i == MenuText.Length- 1 )
                {
                    Graphic.ToCenterY(MenuText.Length);
                }
            }
        }

        public static void Select()
        {
            actions[index].Invoke();
        }

        private static void Play()
        {
            Game.Player = new Hand();
            Game.Opponent = new Hand();
            Deck.Init();
            Frame.Index = (int)Player.In.Game;
        }
        private static void Help()
        {
            Frame.Index = (int)Player.In.Help;
        }
        private static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
