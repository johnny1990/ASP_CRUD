using ASP_Crud.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ASP_Crud.Business
{
    public class Zi
    {
        private const string My_SP = "Zi";

        public int ID { get; set; }
        public DateTime? Data { get; set; }
        public string Checked { get; set; }
        public string Solved { get; set; }
        public string Comments { get; set; }
    


        public static List<Zi> Get(int? id)
        {
            List<SqlParameter> collection = new List<SqlParameter>();
            collection.Add(new SqlParameter("@ID", id));

            IDataReader reader = SQLDB.ExecuteGet(collection, My_SP);
            List<Zi> result = new List<Zi>();
            while (reader.Read())
            {
                Zi zi = new Zi();
                zi.ID = reader["ID"].ToInt().Value;
                zi.Data = reader["Data"].ToDate();
                zi.Checked = reader["Checked"].ToString();
                zi.Solved = reader["Solved"].ToString();
                zi.Comments = reader["Comments"].ToString();
                result.Add(zi);
            }
            return result;
        }

        public static Zi Insert(Zi zi)
        {
            List<SqlParameter> collection = new List<SqlParameter>();
            collection.Add(new SqlParameter("@Data", zi.Data));
            collection.Add(new SqlParameter("@Checked", zi.Checked));
            collection.Add(new SqlParameter("@Solved", zi.Solved));
            collection.Add(new SqlParameter("@Comments", zi.Comments));
            SqlParameter par = new SqlParameter("@ID", SqlDbType.BigInt, sizeof(long));
            par.Direction = System.Data.ParameterDirection.Output;
            collection.Add(par);
            zi.ID = SQLDB.ExecuteInsert(collection, My_SP).ToInt().Value;
            return zi;
        }
    }
}

