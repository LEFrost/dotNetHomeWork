using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期末作业.Models;

namespace 期末作业.ViewModels
{
    public class CourseInfoViewModel : BaseViewModel
    {
        public IEnumerable<CourseMsg> GetCourses()
        {
            var query = from a in _DBMySchool.CourseMsg
                        select a;
            return query;
        }
        public void UpdateData(IEnumerable<CourseMsg> list)
         {
            _DBMySchool.SubmitChanges();
        }
        public void Refresh()
        {
            _DBMySchool.Dispose();
            _DBMySchool = new MySchoolDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["MySchool"].ConnectionString);
        }
    }
}
