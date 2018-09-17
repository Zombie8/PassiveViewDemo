using PassiveViewDemo.Presenters.Interfaces;
using PassiveViewDemo.Views.Forms.Interfaces;

namespace PassiveViewDemo.Presenters
{
    public class MainFormPresenter : IMainFormPresenter, IMainFormPresenterCallbacks
    {
        private IMainFormView _view;
        private int _timesClicked = 0;

        public MainFormPresenter(IMainFormView view)
        {
            _view = view;
            Initialize();
        }

        public object UI
        {
            get { return _view; }
        }

        public void Initialize()
        {
            //_view.Attach(this);
            _view.ButtonText = "Click Me!";
            _view.LabelText = "Before Click...";
        }

        public void OnButtonClicked()
        {
            _timesClicked = _timesClicked + 1;
            _view.ButtonText = "You clicked me!";
            _view.LabelText = $"Button was clicked {_timesClicked} times!";
        }
    }
}
