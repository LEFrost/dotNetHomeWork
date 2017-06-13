using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末作业.Models
{
  	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentMsg")]

    public partial class StudentMsg : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _StudentNo;

        private string _StudentName;

        private System.Nullable<char> _Sex;

        private System.Nullable<System.DateTime> _Birthday;

        private string _Department;

        private string _Speciality;

        private string _Hobby;

        #region 可扩展性方法定义
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnStudentNoChanging(int value);
        partial void OnStudentNoChanged();
        partial void OnStudentNameChanging(string value);
        partial void OnStudentNameChanged();
        partial void OnSexChanging(System.Nullable<char> value);
        partial void OnSexChanged();
        partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
        partial void OnBirthdayChanged();
        partial void OnDepartmentChanging(string value);
        partial void OnDepartmentChanged();
        partial void OnSpecialityChanging(string value);
        partial void OnSpecialityChanged();
        partial void OnHobbyChanging(string value);
        partial void OnHobbyChanged();
        #endregion

        public StudentMsg()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_StudentNo", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int StudentNo
        {
            get
            {
                return this._StudentNo;
            }
            set
            {
                if ((this._StudentNo != value))
                {
                    this.OnStudentNoChanging(value);
                    this.SendPropertyChanging();
                    this._StudentNo = value;
                    this.SendPropertyChanged("StudentNo");
                    this.OnStudentNoChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_StudentName", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string StudentName
        {
            get
            {
                return this._StudentName;
            }
            set
            {
                if ((this._StudentName != value))
                {
                    this.OnStudentNameChanging(value);
                    this.SendPropertyChanging();
                    this._StudentName = value;
                    this.SendPropertyChanged("StudentName");
                    this.OnStudentNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Sex", DbType = "NChar(1)")]
        public System.Nullable<char> Sex
        {
            get
            {
                return this._Sex;
            }
            set
            {
                if ((this._Sex != value))
                {
                    this.OnSexChanging(value);
                    this.SendPropertyChanging();
                    this._Sex = value;
                    this.SendPropertyChanged("Sex");
                    this.OnSexChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Birthday", DbType = "DateTime")]
        public System.Nullable<System.DateTime> Birthday
        {
            get
            {
                return this._Birthday;
            }
            set
            {
                if ((this._Birthday != value))
                {
                    this.OnBirthdayChanging(value);
                    this.SendPropertyChanging();
                    this._Birthday = value;
                    this.SendPropertyChanged("Birthday");
                    this.OnBirthdayChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Department", DbType = "NVarChar(50)")]
        public string Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                if ((this._Department != value))
                {
                    this.OnDepartmentChanging(value);
                    this.SendPropertyChanging();
                    this._Department = value;
                    this.SendPropertyChanged("Department");
                    this.OnDepartmentChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Speciality", DbType = "NVarChar(50)")]
        public string Speciality
        {
            get
            {
                return this._Speciality;
            }
            set
            {
                if ((this._Speciality != value))
                {
                    this.OnSpecialityChanging(value);
                    this.SendPropertyChanging();
                    this._Speciality = value;
                    this.SendPropertyChanged("Speciality");
                    this.OnSpecialityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Hobby", DbType = "NVarChar(200)")]
        public string Hobby
        {
            get
            {
                return this._Hobby;
            }
            set
            {
                if ((this._Hobby != value))
                {
                    this.OnHobbyChanging(value);
                    this.SendPropertyChanging();
                    this._Hobby = value;
                    this.SendPropertyChanged("Hobby");
                    this.OnHobbyChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
