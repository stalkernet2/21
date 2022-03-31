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
                if(i != index)
                {
                    Console.WriteLine(MenuText[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(MenuText[i]);
                    Console.ResetColor();
                }
            }
        }

        public static void Selected()
        {
            actions[index].Invoke();
        }

        private static void Play()
        {
            Game.GameStart = true;
            Deck.Init();
        }
        private static void Help()
        {
            Frame.Help();
        }
        private static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
