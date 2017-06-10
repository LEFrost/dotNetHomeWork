using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期末作业.Models;

namespace 期末作业.ViewModels
{
    public class ModifyWindowViewModel : BaseViewModel
    {
        public bool Modify( StudentMsg student)
        {
            var query = from q in _DBMySchool.StudentMsg
                        where q.StudentNo ==student.StudentNo
                        select q;
            foreach (var item in query)
            {
                item.StudentName = student.StudentName;
                item.Sex = student.Sex;
                item.Speciality = student.Speciality;
                item.Hobby = student.Hobby;
                item.Department = student.Department;
                item.Birthday = student.Birthday;
            }
            try
            {
                _DBMySchool.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
