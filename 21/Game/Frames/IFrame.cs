namespace _21.Frames
{
    interface IFrame
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine(Graphic.Border(1));
            Make();
            Console.WriteLine(Graphic.Border(-1));
        }

        private protected void Make();
    }
}
