using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期末作业.Models;

namespace 期末作业.ViewModels
{
    public class NewCourseInfoViewModel:BaseViewModel
    {
        public void AddCourse(CourseMsg course)
        {
            _DBMySchool.CourseMsg.InsertOnSubmit(course);
            _DBMySchool.SubmitChanges();
        }
    }
}
