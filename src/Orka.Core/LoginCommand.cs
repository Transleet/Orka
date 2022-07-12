using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orka.Core
{
    internal sealed class LoginCommand
    {
        private LoginCommand()
        {
        }
        public static string WtLoginLogin = "wtlogin.login";
        public static string WtLoginExchangeEmp = "wtlogin.exchange_emp";
        public static string WtLoginTransEmp = "wtlogin.trans_emp";
        public static string StatSvcRegister = "StatSvc.register";
        public static string CorrectTime = "Client.CorrectTime";
    }
}
