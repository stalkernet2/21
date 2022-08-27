namespace _21
{
    public partial class Graphic
    {
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

        public static string ToSide(int offset)
        {
            int spaceLength = (Console.WindowWidth - offset) / 2 - 2;
            string space = "";
            for (int i = 0; i <= spaceLength; i++)
            {
                space += " ";
            }
            return space;
        }
    }
}
