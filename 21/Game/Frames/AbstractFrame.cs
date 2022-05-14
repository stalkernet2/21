namespace _21.Frames
{
    abstract class AbstractFrame
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine(Graphic.Border(false));
            Make();
            Console.WriteLine(Graphic.Border(true));
        }

        public abstract void Make();
    }
}
