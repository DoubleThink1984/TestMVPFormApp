using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMVPFormApp
{
    static class Program
    {
        private static IContainer Container { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bootstrap();
            
            //var loginService = new LoginService();

            var mainForm = Container.Resolve<IMainForm>();
            var presenter = Container.Resolve<ILoginViewPresenter>();

            Application.Run((Form)mainForm);
        }

        private static void Bootstrap()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<Form1>().AsSelf().SingleInstance();
            builder.RegisterType<Form1>().As<IMainForm>().InstancePerLifetimeScope();
            builder.RegisterType<LoginService>().As<ILoginService>();
            builder.RegisterType<LoginView>().As<ILoginView>();
            builder.RegisterType<LoginViewPresenter>().As<ILoginViewPresenter>();
            Container = builder.Build();
        }
    }
}
