using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末作业.Utils
{
    public class DBHelper
    {
        private SqlConnection _DBConn;
        public DBHelper(string connectionString)
        {
            _DBConn = new SqlConnection(connectionString);
        }
        /// <summary>
        /// 需调用Close关闭数据库
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public SqlCommand DBSelect(string sqlString)
        {
            SqlCommand comm=null;
            try
            {
                _DBConn.Open();
                 comm= new SqlCommand(sqlString, _DBConn);
            }
            catch(Exception ex)
            {
                _DBConn.Close();
            }
            return comm;
        }
        /// <summary>
        /// 正常执行需手动Close 数据库
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public SqlCommand DBInsert(string sqlString)
        {
            SqlCommand comm = null;
            try
            {
                _DBConn.Open();
                comm = new SqlCommand(sqlString, _DBConn);
            }
            catch(Exception ex)
            {
                _DBConn.Close();
            }
            return comm;
        }
        public bool Close()
        {
            try
            {
                _DBConn.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
      
    }
}
