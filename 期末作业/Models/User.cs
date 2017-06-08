using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末作业.Models
{
    public class User
    {
        private string _UserName;
        private string _Passsword;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string Password
        {
            get { return _Passsword; }
            set { _Passsword = value; }
        }
        //public bool Login()
        //{

        //}
    }
}
