using _21.Main.Menu;
using _21.Frame;

namespace _21
{
    public class Actions : IMenuActions
    {
        public Actions()
        {

        }

        public void OnPlayClick()
        {
            Game.Player = new Hand();
            Game.Opponent = new Hand();
            Game.Pack = new Deck();

            FramePool.Index = (int)Player.In.Game;
            for (int i = 0; i < 2; i++)
            {
                Game.Player.Take();
                Game.Opponent.Take();
            }

        }
        public void OnHelpClick()
        {
            FramePool.Index = (int)Player.In.Help;
        }
    }
}
