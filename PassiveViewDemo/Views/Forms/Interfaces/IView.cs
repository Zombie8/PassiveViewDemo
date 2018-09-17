namespace PassiveViewDemo.Views.Forms.Interfaces
{
    public interface IView<TCallbacks>
    {
        void Attach(TCallbacks presenter);
    }
}
