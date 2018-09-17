namespace PassiveViewDemo.Presenters.Interfaces
{
    public interface IPresenter
    {
        void Initialize();
        object UI { get; }
    }
}
