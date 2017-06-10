using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期末作业.Models;

namespace 期末作业.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public bool IsSuccess(User user)
        {
            var queryResutl = from userResult in _DBMySchool.User
                              where userResult.Equals(user)
                              select userResult;
            if (queryResutl == null)
                return false;
            else
                return true;
        }
    }
}
