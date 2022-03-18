using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_DesignProject.Presenter;

namespace MVP_DesignProject.View
{
    public partial class ValidatedUserView : UserControl, IValidatedUserView
    {
        private readonly ValidatedUserPresenter _presenter;
        public ValidatedUserView()
        {
            InitializeComponent();
            _presenter = new ValidatedUserPresenter(this);
        }
        public string AccountNumber { get => textBoxAccNo.Text; set => textBoxAccNo.Text = value; }
        public string Name { get => labelName.Text; set => labelName.Text = value; }
        public string AccStatus { get => labelAccStatus.Text; set => labelAccStatus.Text = value; }
        public string Currency { get => labelCurrency.Text; set => labelCurrency.Text = value; }

        public event EventHandler SubmitClicked
        {
            add { buttonSubmit.Click += value; }
            remove { buttonSubmit.Click -= value; }
        }
        public event EventHandler CancelClicked
        {
            add { buttonCancel.Click += value; }
            remove { buttonCancel.Click -= value; }
        }
    }

    public interface IValidatedUserView
    {
        string AccountNumber { get; set; }
        string Name { get; set; }
        string AccStatus { get; set; }
        string Currency { get; set; }

        event EventHandler SubmitClicked;
        event EventHandler CancelClicked;
    }  

}
