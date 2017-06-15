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

    public  class CourseMsg : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _CourseId;

        private string _CourseName;

        private string _CourseClass;

        private System.Nullable<bool> _Required;

        private System.Nullable<int> _Credit;

        private System.Nullable<int> _PrelectionCredit;

        private System.Nullable<int> _ExperimentCredit;


        public CourseMsg()
        {
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
                    this.SendPropertyChanging();
                    this._CourseId = value;
                    this.SendPropertyChanged("CourseId");
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
                    this.SendPropertyChanging();
                    this._CourseName = value;
                    this.SendPropertyChanged("CourseName");
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
                    this.SendPropertyChanging();
                    this._CourseClass = value;
                    this.SendPropertyChanged("CourseClass");
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
                    this.SendPropertyChanging();
                    this._Required = value;
                    this.SendPropertyChanged("Required");
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
                    this.SendPropertyChanging();
                    this._Credit = value;
                    this.SendPropertyChanged("Credit");
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
                    this.SendPropertyChanging();
                    this._PrelectionCredit = value;
                    this.SendPropertyChanged("PrelectionCredit");
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
                    this.SendPropertyChanging();
                    this._ExperimentCredit = value;
                    this.SendPropertyChanged("ExperimentCredit");
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
