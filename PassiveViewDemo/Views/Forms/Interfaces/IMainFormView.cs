using PassiveViewDemo.Presenters.Interfaces;

namespace PassiveViewDemo.Views.Forms.Interfaces
{
    public interface IMainFormView : IView<IMainFormPresenterCallbacks>
    {
        string LabelText { get; set; }
        string ButtonText { get; set; }
    }
}
