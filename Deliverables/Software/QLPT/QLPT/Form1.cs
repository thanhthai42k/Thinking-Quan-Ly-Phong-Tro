using QLPT.DAO;
using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPT
{
    public partial class fdangnhap : Form
    {
        public fdangnhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if(h== DialogResult.OK)
            Application.Exit(); 
            }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string username = txttendangnhap.Text;
            string password = txtmatkhau.Text;
           if(login(username, password))
           {
               account loginaccount = AccountDAO.Instance.GetAccountByUserName(username);
               fquanly f = new fquanly(loginaccount);
               this.Hide();
               f.ShowDialog();
               this.Show();
           }
        else
           {
               MessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu");
           }
         

        }
        bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username,password);
        }

        private void fdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txttendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     }
}

