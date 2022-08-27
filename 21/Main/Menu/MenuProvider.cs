using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public abstract class MenuProvider
    {
        public int Index;
        public abstract void ChooseIndex();

        public abstract void Select();
    }
}
