using _21.Frame.Frames;

namespace _21.Frame
{
    public class FramePool
    {
        private static readonly IFrame[] _pool = { new InMenu(), new InHelp(), new InGame(), new InEnd() };
        public static int Index = 0;

        public static void Draw()
        {
            var show = _pool[Index].Show;
            show.Invoke();
        }
    }
}
