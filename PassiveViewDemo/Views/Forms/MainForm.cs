using System.Windows.Forms;

using PassiveViewDemo.Presenters;
using PassiveViewDemo.Presenters.Interfaces;
using PassiveViewDemo.Views.Forms.Interfaces;

namespace PassiveViewDemo.Views.Forms
{
    public partial class MainForm : Form, IMainFormView
    {
        public MainForm()
        {
            InitializeComponent();

            var presenter = new MainFormPresenter(this);
            this.Attach(presenter);
        }

        public string LabelText
        {
            get { return MessageLabel.Text; }
            set { MessageLabel.Text = value; }
        }

        public string ButtonText
        {
            get { return ClickButton.Text; }
            set { ClickButton.Text = value; }
        }

        public void Attach(IMainFormPresenterCallbacks callback)
        {
            ClickButton.Click += (sender, e) => callback.OnButtonClicked();
        }
    }
}
