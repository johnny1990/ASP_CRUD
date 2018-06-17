using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ASP_Crud.DLL
{
    public class SQLDB
    {
        public static string MainConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["mainConnection"].ConnectionString;
            }
        }

        public static IDataReader ExecuteGet(List<SqlParameter> paramsList, string My_SP)
        {

            SqlConnection con = new SqlConnection(MainConnectionString);

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            command.CommandText = My_SP + "_get";
            command.CommandTimeout = 0;
            DataTable dt = new DataTable();
            foreach (var param in paramsList)
            {
                command.Parameters.Add(param);
            }
            try
            {
                con.Open();
                using (TransactionScope ts = new TransactionScope())
                {
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                //Regio.Logger.LogWriter.LogException(ex);
            }
            finally
            {
                con.Close();
            }
            return dt.CreateDataReader();
        }


        public static long? ExecuteInsert(List<SqlParameter> paramsList, string My_SP)
        {
            long? ID = null;
            SqlConnection con = new SqlConnection(MainConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            command.CommandText = My_SP + "_create";
            command.CommandTimeout = 0;
            DataTable dt = new DataTable();
            foreach (var param in paramsList)
            {
                command.Parameters.Add(param);
            }
            try
            {
                con.Open();
                using (TransactionScope ts = new TransactionScope())
                {
                    ID = Convert.ToInt64(command.ExecuteScalar());
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
               // Regio.Logger.LogWriter.LogException(ex);
            }
            finally
            {
                con.Close();
            }
            return ID;

        }

        public static void ExecuteDelete(List<SqlParameter> paramsList, string My_SP)
        {
            SqlConnection con = new SqlConnection(MainConnectionString);

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            command.CommandText = My_SP + "_delete";
            command.CommandTimeout = 0;
            DataTable dt = new DataTable();
            foreach (var param in paramsList)
            {
                command.Parameters.Add(param);
            }
            try
            {
                con.Open();
                using (TransactionScope ts = new TransactionScope())
                {
                    command.ExecuteNonQuery();
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }
        }

        public static void ExecuteUpdate(List<SqlParameter> paramsList, string My_SP)
        {
            SqlConnection con = new SqlConnection(MainConnectionString);

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            command.CommandText = My_SP + "_update";
            command.CommandTimeout = 0;
            DataTable dt = new DataTable();
            foreach (var param in paramsList)
            {
                command.Parameters.Add(param);
            }
            try
            {
                con.Open();
                using (TransactionScope ts = new TransactionScope())
                {
                    command.ExecuteNonQuery();
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                //Regio.Logger.LogWriter.LogException(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public static void ExecuteNonQuery(string Query)
        {
            SqlConnection con = new SqlConnection(MainConnectionString);

            SqlCommand command = new SqlCommand(Query, con);
            try
            {
                con.Open();
                using (TransactionScope ts = new TransactionScope())
                {
                    command.ExecuteNonQuery();
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                //Regio.Logger.LogWriter.LogException(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

