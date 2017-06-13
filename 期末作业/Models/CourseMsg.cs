using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末作业.Models
{
    	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CourseMsg")]

    public partial class CourseMsg : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _CourseId;

        private string _CourseName;

        private string _CourseClass;

        private System.Nullable<bool> _Required;

        private System.Nullable<int> _Credit;

        private System.Nullable<int> _PrelectionCredit;

        private System.Nullable<int> _ExperimentCredit;

        #region 可扩展性方法定义
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnCourseIdChanging(int value);
        partial void OnCourseIdChanged();
        partial void OnCourseNameChanging(string value);
        partial void OnCourseNameChanged();
        partial void OnCourseClassChanging(string value);
        partial void OnCourseClassChanged();
        partial void OnRequiredChanging(System.Nullable<bool> value);
        partial void OnRequiredChanged();
        partial void OnCreditChanging(System.Nullable<int> value);
        partial void OnCreditChanged();
        partial void OnPrelectionCreditChanging(System.Nullable<int> value);
        partial void OnPrelectionCreditChanged();
        partial void OnExperimentCreditChanging(System.Nullable<int> value);
        partial void OnExperimentCreditChanged();
        #endregion

        public CourseMsg()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CourseId", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int CourseId
        {
            get
            {
                return this._CourseId;
            }
            set
            {
                if ((this._CourseId != value))
                {
                    this.OnCourseIdChanging(value);
                    this.SendPropertyChanging();
                    this._CourseId = value;
                    this.SendPropertyChanged("CourseId");
                    this.OnCourseIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CourseName", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CourseName
        {
            get
            {
                return this._CourseName;
            }
            set
            {
                if ((this._CourseName != value))
                {
                    this.OnCourseNameChanging(value);
                    this.SendPropertyChanging();
                    this._CourseName = value;
                    this.SendPropertyChanged("CourseName");
                    this.OnCourseNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CourseClass", DbType = "NVarChar(50)")]
        public string CourseClass
        {
            get
            {
                return this._CourseClass;
            }
            set
            {
                if ((this._CourseClass != value))
                {
                    this.OnCourseClassChanging(value);
                    this.SendPropertyChanging();
                    this._CourseClass = value;
                    this.SendPropertyChanged("CourseClass");
                    this.OnCourseClassChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Required", DbType = "Bit")]
        public System.Nullable<bool> Required
        {
            get
            {
                return this._Required;
            }
            set
            {
                if ((this._Required != value))
                {
                    this.OnRequiredChanging(value);
                    this.SendPropertyChanging();
                    this._Required = value;
                    this.SendPropertyChanged("Required");
                    this.OnRequiredChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Credit", DbType = "Int")]
        public System.Nullable<int> Credit
        {
            get
            {
                return this._Credit;
            }
            set
            {
                if ((this._Credit != value))
                {
                    this.OnCreditChanging(value);
                    this.SendPropertyChanging();
                    this._Credit = value;
                    this.SendPropertyChanged("Credit");
                    this.OnCreditChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_PrelectionCredit", DbType = "Int")]
        public System.Nullable<int> PrelectionCredit
        {
            get
            {
                return this._PrelectionCredit;
            }
            set
            {
                if ((this._PrelectionCredit != value))
                {
                    this.OnPrelectionCreditChanging(value);
                    this.SendPropertyChanging();
                    this._PrelectionCredit = value;
                    this.SendPropertyChanged("PrelectionCredit");
                    this.OnPrelectionCreditChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ExperimentCredit", DbType = "Int")]
        public System.Nullable<int> ExperimentCredit
        {
            get
            {
                return this._ExperimentCredit;
            }
            set
            {
                if ((this._ExperimentCredit != value))
                {
                    this.OnExperimentCreditChanging(value);
                    this.SendPropertyChanging();
                    this._ExperimentCredit = value;
                    this.SendPropertyChanged("ExperimentCredit");
                    this.OnExperimentCreditChanged();
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
