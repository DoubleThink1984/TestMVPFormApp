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
        private IMainForm _mainForm;

        public LoginViewPresenter(IMainForm mainForm)
        {
            this._mainForm = mainForm;
            this._loginView = mainForm.LoginView;

            _loginView.SearchButtonPressed += OnSearchButtonPressed;
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            _loginView.SetInputText("This might be working");
        }
    }
}
