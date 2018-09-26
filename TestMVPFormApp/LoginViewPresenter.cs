using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVPFormApp
{
    public class LoginViewPresenter
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
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            _loginView.SetInputText("This might be working");
        }

        private async void OnSearchInputClicked(object sender, EventArgs e)
        {
            await _loginService.WaitForService();
            _loginView.ClearSearchBoxText();
        }
    }
}
