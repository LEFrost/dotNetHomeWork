using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末作业.Models
{
   [System.Data.Linq.Mapping.Table(Name="dbo.ScoreMsg")]

    public  class ScoreMsg : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _StudentNo;

        private int _CourseId;

        private System.Nullable<int> _Score;


        public ScoreMsg()
        {
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
                    this.SendPropertyChanging();
                    this._StudentNo = value;
                    this.SendPropertyChanged("StudentNo");
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
                    this.SendPropertyChanging();
                    this._CourseId = value;
                    this.SendPropertyChanged("CourseId");
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
                    this.SendPropertyChanging();
                    this._Score = value;
                    this.SendPropertyChanged("Score");
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
