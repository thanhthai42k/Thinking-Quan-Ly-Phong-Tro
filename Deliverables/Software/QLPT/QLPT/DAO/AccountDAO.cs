using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }

            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool login(string username, string password )
        {
            string query = "pLogin @username , @password ";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object []{username, password});

            return result.Rows.Count > 0;

        }
        public bool UpdateAccount (string username, string password, string newpassword)
        {
            int result  = DataProvider.Instance.ExcuteNonQuery("exec UpdateAccount @username, @password, @newpassword", new object[] { username, password, newpassword });
            return result >0;

        }
      /*  public bool UpdateAccount(string username, string password, string newpassword)
        {
            var commandText = "UPDATE TaiKhoan SET usernane=@username, password=@password, newpassword =@newpassword";
            SqlCommand cmd = new SqlCommand(commandText); //, DataProvider.Instance
            int result = DataProvider.Instance.ExcuteNonQuery(cmd);
            return result > 0;
        }*/
        public account GetAccountByUserName (string username)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from TaiKhoan where TenTaiKhoan = '"+username+"'");

            foreach(DataRow item in data.Rows)
            {
                return new account(item);
            }
            return null;
        }
    }
}
