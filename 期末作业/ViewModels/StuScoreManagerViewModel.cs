using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期末作业.Models;

namespace 期末作业.ViewModels
{
    public class StuScoreManagerViewModel : BaseViewModel
    {
        public IEnumerable<ScoreMsg> LoadScores()
        {
            var query = from a in _DBMySchool.ScoreMsg
                        select a;
            return query;
        }

  
        public string QueryCourseName(int courseId)
        {
            var query = _DBMySchool.CourseMsg.SingleOrDefault(a => a.CourseId == courseId);
            if (query == null)
                return "";
            else
                return query.CourseName;
        }
        public string QueryStudentName(int stuNo)
        {
            var query = _DBMySchool.StudentMsg.SingleOrDefault(a => a.StudentNo == stuNo);
            if (query == null)
                return "";
            else
                return query.StudentName;
        }
        public bool AddScore(ScoreMsg score)
        {
            _DBMySchool.ScoreMsg.InsertOnSubmit(score);
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
        public bool UpdateScore(ScoreMsg score)
        {
            var query = _DBMySchool.ScoreMsg.Where(x => x.CourseId == score.CourseId && x.StudentNo == score.StudentNo);
            foreach (var item in query)
            {
                item.Score = score.Score;
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
        public bool DeleteScore(ScoreMsg score)
        {
            var query = from q in _DBMySchool.ScoreMsg
                        where score.CourseId == q.CourseId && score.StudentNo == q.StudentNo
                        select q;
                _DBMySchool.ScoreMsg.DeleteAllOnSubmit(query);
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
