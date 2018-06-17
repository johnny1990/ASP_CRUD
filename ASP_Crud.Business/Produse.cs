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
    public class Produse
    {
        private const string My_SP = "Produse";


        public int ID { get; set; }
        public string Produs { get; set; }
        public decimal? Pret { get; set; }
        public int? Cantitate { get; set; }
        public string Categorie { get; set; }


        public static List<Produse> Get(int? id, string produs)
        {
            List<SqlParameter> collection = new List<SqlParameter>();
            collection.Add(new SqlParameter("@ID", id));
            collection.Add(new SqlParameter("@Produs", produs));

            IDataReader reader = SQLDB.ExecuteGet(collection, My_SP);
            List<Produse> result = new List<Produse>();
            while (reader.Read())
            {
                Produse prod = new Produse();
                prod.ID = reader["ID"].ToInt().Value;
                prod.Produs = reader["Produs"].ToString();
                prod.Pret = reader["Pret"].ToDecimal();
                prod.Cantitate = reader["Cantitate"].ToInt();
                prod.Categorie = reader["Categorie"].ToString();
                result.Add(prod);
            }
            return result;
        }

        public static Produse Insert(Produse prod)
        {
            List<SqlParameter> collection = new List<SqlParameter>();
            collection.Add(new SqlParameter("@Produs", prod.Produs));
            collection.Add(new SqlParameter("@Pret", prod.Pret));
            collection.Add(new SqlParameter("@Cantitate", prod.Cantitate));
            collection.Add(new SqlParameter("@Categorie", prod.Categorie));

            SqlParameter par = new SqlParameter("@ID", SqlDbType.BigInt, sizeof(long));
            par.Direction = System.Data.ParameterDirection.Output;
            collection.Add(par);
            prod.ID = SQLDB.ExecuteInsert(collection, My_SP).ToInt().Value;
            return prod;
        }

        public static void Delete(int id)
        {
            List<SqlParameter> collection = new List<SqlParameter>();
            collection.Add(new SqlParameter("@ID", (object)id));
            SQLDB.ExecuteDelete(collection, My_SP);
        }

        public static Produse Update(Produse prod)
        {
            List<SqlParameter> collection = new List<SqlParameter>();
            collection.Add(new SqlParameter("@ID", prod.ID));
            collection.Add(new SqlParameter("@Produs", prod.Produs));
            collection.Add(new SqlParameter("@Pret", prod.Pret));
            collection.Add(new SqlParameter("@Cantitate", prod.Cantitate));
            collection.Add(new SqlParameter("@Categorie", prod.Categorie));

            SQLDB.ExecuteUpdate(collection, My_SP);
            return prod;

        }
    }
}
