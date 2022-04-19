using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicProFW.Win.Helpers
{
    static class Global
    {
        private static string _userLogin = "";
        private static string _userTipo = "";
        public static string UserLogin
        {
            get { return _userLogin; }
            set { _userLogin = value; }
        }
        public static string UserTipo
        {
            get { return _userTipo; }
            set { _userTipo = value; }
        }
    }
}
