using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestMVPFormApp
{
    public class LoginService : ILoginService
    {
        public LoginService()
        {

        }

        public async Task WaitForService()
        {
            await Task.Delay(2000);
        }

        //public async Task WaitForThis()
        //{
        //    Timer myTimer = new Timer(1000);
        //}
    }

    public interface ILoginService
    {
        Task WaitForService();
    }
}
