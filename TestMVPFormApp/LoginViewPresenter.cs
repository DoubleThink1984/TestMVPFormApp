using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMVPFormApp
{
    public class LoginViewPresenter : ILoginViewPresenter
    {
        private ILoginView _loginView;
        private ILoginService _loginService;
        private IMainForm _mainForm;

        public LoginViewPresenter(IMainForm mainForm, ILoginService loginService)
        {
            this._mainForm = mainForm;
            this._loginView = mainForm.LoginView;
            this._loginService = loginService;
            _loginView.SearchButtonPressed += OnSearchButtonPressed;
            _loginView.SearchInputClicked += OnSearchInputClicked;
            _loginView.SearchInputValidating += OnSearchInputValidating;
        }

        public void OnSearchButtonPressed(object sender, EventArgs e)
        {            
            _loginView.SetInputText("This might be working");
            //_loginView.ShowErrorproviderText("There may have been an issue");
        }

        public async void OnSearchInputClicked(object sender, EventArgs e)
        {
            await _loginService.WaitForService();
            _loginView.ClearSearchBoxText();
            _loginView.SetSearchTextBoxForeColor(Color.Blue);
        }

        public void OnSearchInputValidating(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var asdf = e as System.ComponentModel.CancelEventArgs;
            _loginView.ShowErrorproviderText($"{textBox.Text} is not a valid value for this textbox.\nPlease enter a valid value.");
        }
    }

    public interface ILoginViewPresenter
    {
        void OnSearchInputClicked(object sender, EventArgs e);
        void OnSearchButtonPressed(object sender, EventArgs e);
        void OnSearchInputValidating(object sender, EventArgs e);
    }
}
