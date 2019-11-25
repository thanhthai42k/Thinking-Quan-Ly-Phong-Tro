using QLPT.DAO;
using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPT
{
    public partial class faccountprofile : Form
    {
        private account loginAccount;

        public account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

      
        void ChangeAccount (account acc)
        {
            txttennguoidung.Text = LoginAccount.Username;
          
        }
        void UpdateAccount ()
        {
            
            string password = txtmatkhautt.Text;
            string newpassword = txtmatkhaumoi.Text;
            string nhaplaipassword = txtnhaplaimatkhau.Text;
            string username = txttennguoidung.Text;
            if (!newpassword.Equals(nhaplaipassword))
            {
                MessageBox.Show("Vui lòng nhập lại password đúng với pasword mới");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, password, newpassword))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }
       
        public faccountprofile( account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

       // public faccountprofile(account loginAccount)
       // {
            // TODO: Complete member initialization
            //this.LoginAccount = loginAccount;
      //  }

        private void btnthoattt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        public account acc { get; set; }
    }
}
/* if (txtmatkhautt.Text == "" && txtmatkhaumoi.Text == "" ){
               MessageBox.Show("Vui lòng nhập đúng mật khẩu");
           }
           else
           {
               string query = "Update TaiKhoan set password ='"+txtmatkhaumoi+"'";
               datatable data = DataProvider.Instance.ExcuteNonQuery(query);
           }*/