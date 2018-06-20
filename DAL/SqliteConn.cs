using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class SqliteConn
    {
        //private static readonly string str = @"Data Source=" + System.Environment.CurrentDirectory + @"\gyyy.db;";
        private static readonly string str = @"Data Source=E:\gyyy.db;Pooling=true;FailIfMissing=false";




        public static DataTable ExecuteTable(string sql, params SQLiteParameter[] sqLiteParameters)
        {
            DataTable dataTable = new DataTable();

            SQLiteConnection sqLiteConnection = new SQLiteConnection(str);
            
            sqLiteConnection.Open();

            using (SQLiteDataAdapter sqLiteDataAdapter = new SQLiteDataAdapter(sql, sqLiteConnection))
            {
                if (sqLiteParameters != null)
                {
                    sqLiteDataAdapter.SelectCommand.Parameters.AddRange(sqLiteParameters);
                }

                sqLiteDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}