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
        }

        public event EventHandler SearchButtonPressed;

        protected virtual void OnSearchButtonPressed()
        {
            SearchButtonPressed?.Invoke(this, EventArgs.Empty);
        }

        public void ClearInputText()
        {
            throw new NotImplementedException();
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
        string GetInputText();
        void SetInputText(string txt);
        void ClearInputText();
    }
}
