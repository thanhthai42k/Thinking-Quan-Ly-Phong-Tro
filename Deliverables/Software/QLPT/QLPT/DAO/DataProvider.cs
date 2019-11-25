using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; // đóng gói để cho là duy nhất ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
           private set { DataProvider.instance = value; }
        }

        private DataProvider(){}

        private string connectionSTR = @"Data Source=desktop-c61is1j\sqlexpress;Initial Catalog=thinking;Integrated Security=True";
       public DataTable ExcuteQuery(String query, object[] parameter = null)
       {
           DataTable data = new DataTable();

           using (SqlConnection connection = new SqlConnection(connectionSTR)) 
           { 
           connection.Open();

           SqlCommand command = new SqlCommand(query, connection);

           if (parameter != null)
           {
               string[] listpara = query.Split(' ');

               int i = 0;

               foreach (string item in listpara)
               {
                   if(item.Contains("@"))
                   {
                       command.Parameters.AddWithValue(item, parameter[i]);
                       i++;
                   }

               }
           }

           SqlDataAdapter adapter = new SqlDataAdapter(command);

           adapter.Fill(data);

           connection.Close();
           }
           return data;
           
       }
 
       public DataTable dataTable { get; set; }

       internal DataTable ExcuteQuery()
       {
           throw new NotImplementedException();
       }


     

       public SqlConnection connection { get; set; }

       internal int ExcuteNonQuery(string p1, object[] p2)
       {
           throw new NotImplementedException();
       }




       internal int ExcuteNonQuery(SqlCommand cmd)
       {
           throw new NotImplementedException();
       }
    }
}
