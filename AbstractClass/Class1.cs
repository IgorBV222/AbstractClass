using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace AbstractClass
{
    public abstract class DBJob
    {
        public DBJob(string constr)
        {
            ConnString = constr;    
        }
        public DbConnection Conn;
        public string ConnString { get; set; }
        public abstract DbConnection GetDbConnection();
    }//end abstract Class

    public class SQLLiteDBJob : DBJob
    {
        private SQLiteConnection _conn;
        public SQLLiteDBJob(string constr) : base(constr) {}        

        public override DbConnection GetDbConnection()
        {
            throw new NotImplementedException();
            _conn = new SQLiteConnection(ConnString);
            Conn= _conn;
            return Conn;
        }
    }//end Class
}