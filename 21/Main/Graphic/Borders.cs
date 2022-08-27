using System.Text;

namespace _21
{
    public partial class Graphic
    {
        private static readonly int BorderSize = 3;
        private static readonly char[] BorderChars = new char[4] { '\u2588', '\u2593', '\u2592', '\u2591' };

        public static string Border(bool inDown)
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

            switch (inDown)
            {
                case false:
                    return borderLine.ToString();
                case true:
                    string space = "";

                    for (int i = 0; i < (Console.WindowHeight - (Console.CursorTop + 4)); i++)
                    {
                        space += "\n";
                    }
                    return space + TrueReverse(borderLine);
            }
        }

        private static string TrueReverse(StringBuilder text)
        {
            char[] reverseChar = text.ToString().Reverse().ToArray();
            return new string(reverseChar);
        }
    }
}
