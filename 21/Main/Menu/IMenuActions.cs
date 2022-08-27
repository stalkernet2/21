namespace _21.Main.Menu
{
    public interface IMenuActions
    {
        public void OnPlayClick();
        public void OnHelpClick();
        public void OnExitClick()
        {
            Environment.Exit(0);
        }
    }
}
