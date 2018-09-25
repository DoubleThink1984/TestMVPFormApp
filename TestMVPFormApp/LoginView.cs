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
        }

        public event EventHandler SearchButtonPressed;
        public event EventHandler SearchInputClicked;

        protected virtual void OnSearchButtonPressed()
        {
            SearchButtonPressed?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnSearchInputClicked()
        {
            SearchInputClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ClearSearchBoxText()
        {
            this.txtBoxSearchInput.Text = "";
            this.txtBoxSearchInput.ForeColor = Color.Black;
        }

        public string GetInputText()
        {
            throw new NotImplementedException();
        }

        public void SetInputText(string txt)
        {
            this.txtBoxSearchInput.Text = txt;
        }                
    }

    public interface ILoginView
    {
        event EventHandler SearchButtonPressed;
        event EventHandler SearchInputClicked;
        string GetInputText();
        void SetInputText(string txt);
        void ClearSearchBoxText();
    }
}
