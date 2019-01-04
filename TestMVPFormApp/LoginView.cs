using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMVPFormApp
{
    public partial class LoginView : UserControl, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            buttonSearch.Click += (s, a) => OnSearchButtonPressed();
            txtBoxSearchInput.Click += (s, a) => OnSearchInputClicked();
            txtBoxSearchInput.Validating += new System.ComponentModel.CancelEventHandler(this.OnSearchInputValidating);
        }

        public event EventHandler SearchButtonPressed;
        public event EventHandler SearchInputClicked;
        public event CancelEventHandler SearchInputValidating;

        protected virtual void OnSearchButtonPressed()
        {
            SearchButtonPressed?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnSearchInputClicked()
        {
            SearchInputClicked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnSearchInputValidating(object sender, CancelEventArgs e)
        {
            var asdf = e;
            SearchInputValidating?.Invoke(sender, e);
        }

        public void ClearSearchBoxText()
        {
            this.txtBoxSearchInput.Text = "";
        }

        public void SetSearchTextBoxForeColor(Color color)
        {
            this.txtBoxSearchInput.ForeColor = color;
        }

        public string GetInputText()
        {
            throw new NotImplementedException();
        }

        public void SetInputText(string txt)
        {
            this.txtBoxSearchInput.Text = txt;
        }

        public void ShowErrorproviderText(string errorMessage)
        {
            this.inputTextErrorProvider.SetError(this.txtBoxSearchInput, errorMessage);
        }
        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);    
        }
    }

    public interface ILoginView
    {
        event EventHandler SearchButtonPressed;
        event EventHandler SearchInputClicked;
        event CancelEventHandler SearchInputValidating;
        string GetInputText();
        void SetInputText(string txt);
        void ClearSearchBoxText();
        void ShowErrorproviderText(string errorMessage);
        void SetSearchTextBoxForeColor(Color color);
    }
}
