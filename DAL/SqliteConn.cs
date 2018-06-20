using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class SqliteConn
    {
        private static readonly string str = @"Data Source=" + System.Environment.CurrentDirectory + @"\gyyy.db;";
        //private static readonly string str = @"Data Source=E:\gyyy.db;Pooling=true;FailIfMissing=false";


        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] sqLiteParameters)
        {
            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(str))
            {
                using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sql, sqLiteConnection))
                {
                    if (sqLiteParameters.Length > 0)
                    {
                        sqLiteCommand.Parameters.AddRange(sqLiteParameters);
                    }
                    sqLiteConnection.Open();
                    return sqLiteCommand.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteTable(string sql, params SQLiteParameter[] sqLiteParameters)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteDataAdapter sqLiteDataAdapter = new SQLiteDataAdapter(sql, str))
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