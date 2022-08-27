namespace _21
{
    public interface IMenuProvider : ISome, IDisposable
    {
        public void ShowSelectedAction();
        public void InvokeAction();
        public void MoveToUpElement();
        public void MoveToDownElement();
    }
}
