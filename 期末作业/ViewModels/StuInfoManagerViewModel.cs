using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期末作业.Models;

namespace 期末作业.ViewModels
{
    public class StuInfoManagerViewModel : BaseViewModel
    {
        public IEnumerable<StudentMsg> GetStudents()
        {
            IEnumerable<StudentMsg> result = from q in _DBMySchool.StudentMsg
                                             select q;
            return result;
        }
        public StudentMsg GetStudent(int StuNo)
        {
            return _DBMySchool.StudentMsg.SingleOrDefault(x => x.StudentNo == StuNo);
                
        }
   
        public bool Delete(int StuNo)
        {
            var query = from q in _DBMySchool.StudentMsg
                        where q.StudentNo == StuNo
                        select q;
            _DBMySchool.StudentMsg.DeleteAllOnSubmit(query);
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
