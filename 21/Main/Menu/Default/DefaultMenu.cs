using _21.Main.Menu;

namespace _21
{
    public class DefaultMenu : IMenuProvider
    {
        private int _index = 0;
        private readonly string[] _menuText = { "Начать игру", "Помощь", "Выход" };

        private readonly IMenuActions _menuActions;
        private readonly Action[] _actions;

        public DefaultMenu()
        {
            _menuActions = new Actions();
            _actions = new Action[]
            {
                _menuActions.OnPlayClick,
                _menuActions.OnHelpClick,
                _menuActions.OnExitClick
            };
        }

        public void ShowSelectedAction()
        {
            for (int i = 0; i < _menuText.Length; i++)
            {
                if (i == 0)
                    Graphic.ToCenterY(_menuText.Length);

                if (i != _index)
                    Console.WriteLine(Graphic.ToCenterX(_menuText[i]));
                else
                {
                    Console.Write(Graphic.ToSide(_menuText[i]));
                    Graphic.InverseText(_menuText[i]);
                    Console.WriteLine();
                }
            }
        }

        public void InvokeAction()
        {
            _actions[_index].Invoke();
        }

        public void MoveToUpElement()
        {
            if (_index > 0)
                _index--;
            else
                _index = _menuText.Length - 1;
        }

        public void MoveToDownElement()
        {
            if (_index < _menuText.Length - 1)
                _index++;
            else
                _index = 0;
        }

        public void Dispose()
        {
            _index = 0;

            GC.SuppressFinalize(this);
            GC.Collect();
        }

    }
}
