using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末作业.Models
{
  	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MySchool")]

    public partial class MySchoolDataContext : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        #region 可扩展性方法定义
        partial void OnCreated();
        partial void InsertCourseMsg(CourseMsg instance);
        partial void UpdateCourseMsg(CourseMsg instance);
        partial void DeleteCourseMsg(CourseMsg instance);
        partial void InsertScoreMsg(ScoreMsg instance);
        partial void UpdateScoreMsg(ScoreMsg instance);
        partial void DeleteScoreMsg(ScoreMsg instance);
        partial void InsertStudentMsg(StudentMsg instance);
        partial void UpdateStudentMsg(StudentMsg instance);
        partial void DeleteStudentMsg(StudentMsg instance);
        partial void InsertUser(User instance);
        partial void UpdateUser(User instance);
        partial void DeleteUser(User instance);
        #endregion

        public MySchoolDataContext() :
                base(global::期末作业.Properties.Settings.Default.MySchoolConnectionString, mappingSource)
        {
            OnCreated();
        }

        public MySchoolDataContext(string connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public MySchoolDataContext(System.Data.IDbConnection connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public MySchoolDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public MySchoolDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<CourseMsg> CourseMsg
        {
            get
            {
                return this.GetTable<CourseMsg>();
            }
        }

        public System.Data.Linq.Table<ScoreMsg> ScoreMsg
        {
            get
            {
                return this.GetTable<ScoreMsg>();
            }
        }

        public System.Data.Linq.Table<StudentMsg> StudentMsg
        {
            get
            {
                return this.GetTable<StudentMsg>();
            }
        }

        public System.Data.Linq.Table<User> User
        {
            get
            {
                return this.GetTable<User>();
            }
        }
    }

}
