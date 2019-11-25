using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class account
    {
        public account (string username, int type, string password = null)
        {
            this.Username = username;
            this.Type = type;
            this.Password = password;
        }
        public account (DataRow row)
        {
            this.Username = row["TenTaiKhoan"].ToString();
            this.Type = (int)row["LoaiTk"];
            this.Password = row["password"].ToString();
           
        }
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
