using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace DAL
{
    public class SqliteConn
    {
        private static readonly string str = @"Data Source=" + System.Environment.CurrentDirectory + @"\gyyy.db;";
        //private static readonly string str = @"Data Source=E:\gyyy.db;Pooling=true;FailIfMissing=false";

        #region 修改多条记录 主要针对发票修改
        /// <summary>
        /// 修改多条记录 主要针对发票修改
        /// </summary>
        /// <param name="sqlList">SQL语句List</param>
        /// <param name="paramList">对应的参数List</param>
        /// <returns></returns>
        public static int ExeCuteNonQueryMulit(List<string> sqlList, List<List<SQLiteParameter>> paramList)
        {
            int yyhs = 0;
            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(str))
            {
                sqLiteConnection.Open();
                using (SQLiteTransaction sqLiteTransaction = sqLiteConnection.BeginTransaction())
                {
                    using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection))
                    {
                        sqLiteCommand.Transaction = sqLiteTransaction;
                        for (int i = 0; i < sqlList.Count; i++)
                        {
                            sqLiteCommand.CommandText = sqlList[i];
                            sqLiteCommand.Parameters.AddRange(paramList[i].ToArray());
                            yyhs = yyhs + sqLiteCommand.ExecuteNonQuery();
                        }
                        sqLiteTransaction.Commit();
                    }
                }
            }
            return yyhs;
        }

        #endregion



        public static int ExecuteNonQueryMulit(string sql, List<List<SQLiteParameter>> list)
        {
            int yyhs = 0;
            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(str))
            {
                sqLiteConnection.Open();
                using (SQLiteTransaction sqLiteTransaction = sqLiteConnection.BeginTransaction())
                {
                    using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sql, sqLiteConnection))
                    {
                        sqLiteCommand.Transaction = sqLiteTransaction;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sqLiteCommand.Parameters.AddRange(list[i].ToArray());
                            yyhs = yyhs + sqLiteCommand.ExecuteNonQuery();
                        }
                        sqLiteTransaction.Commit();
                    }
                }
            }

            return yyhs;
        }



        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqLiteParameters"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] sqLiteParameters)
        {
            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(str))
            {
                using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sql, sqLiteConnection))
                {
                    if (sqLiteParameters != null)
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