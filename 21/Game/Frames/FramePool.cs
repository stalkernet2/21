using _21.Frames;

namespace _21
{
    public class FramePool
    {
        private static IFrame[] Pool = { new InMenu(), new InHelp(), new InGame(), new InEnd() };
        public static int Index = 0;

        public static void Draw()
        {
            Action show = Pool[Index].Show;
            show.Invoke();
        }
    }
}
