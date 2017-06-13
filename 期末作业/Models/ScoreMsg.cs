using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末作业.Models
{
   [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ScoreMsg")]

    public partial class ScoreMsg : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _StudentNo;

        private int _CourseId;

        private System.Nullable<int> _Score;

        #region 可扩展性方法定义
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnStudentNoChanging(int value);
        partial void OnStudentNoChanged();
        partial void OnCourseIdChanging(int value);
        partial void OnCourseIdChanged();
        partial void OnScoreChanging(System.Nullable<int> value);
        partial void OnScoreChanged();
        #endregion

        public ScoreMsg()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_StudentNo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CourseId", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Score", DbType = "Int")]
        public System.Nullable<int> Score
        {
            get
            {
                return this._Score;
            }
            set
            {
                if ((this._Score != value))
                {
                    this.OnScoreChanging(value);
                    this.SendPropertyChanging();
                    this._Score = value;
                    this.SendPropertyChanged("Score");
                    this.OnScoreChanged();
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
