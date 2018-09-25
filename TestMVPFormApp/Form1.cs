using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMVPFormApp
{
    public partial class Form1 : Form, IMainForm
    {
        public ILoginView _loginView;
        public Form1()
        {
            InitializeComponent();
            this._loginView = loginView1;
        }

        public ILoginView LoginView { get { return this._loginView;  } }
    }

    public interface IMainForm
    {
        ILoginView LoginView { get; }
    }
}
