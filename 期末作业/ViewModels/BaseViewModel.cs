using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期末作业.Models;

namespace 期末作业.ViewModels
{
    public class BaseViewModel:IDisposable
    {
        protected MySchoolDataContext _DBMySchool = new MySchoolDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["MySchool"].ConnectionString);

        public void Dispose()
        {
            _DBMySchool.Dispose();
        }
    }
}
