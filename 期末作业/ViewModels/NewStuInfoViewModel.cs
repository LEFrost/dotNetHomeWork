using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期末作业.Models;
using System.Configuration;

namespace 期末作业.ViewModels
{
    public class NewStuInfoViewModel:BaseViewModel
    {
        public void AddStudent(StudentMsg student)
        {
            _DBMySchool.StudentMsg.InsertOnSubmit(student);
            _DBMySchool.SubmitChanges();
        }
    }

}
