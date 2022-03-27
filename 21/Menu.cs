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
        private static string[] MenuText = { "Начать игру", "Настройки", "Выход" };
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


    }
}
