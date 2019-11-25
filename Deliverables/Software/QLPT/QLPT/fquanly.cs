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
    public partial class fquanly : Form
    {
        private account loginAccount;

        public account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public fquanly(account acc)
        {
            InitializeComponent();
            this.LoginAccount= acc;
            LoadTable();
        }

        #region method
        void ChangeAccount(int type)
        {
            stripquanly.Enabled = type == 1;
            thôngTinCáNhânToolStripMenuItem.Text += "(" + LoginAccount.Username + ")";
        }
        void LoadTable()
        {
           List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach(Table item in tablelist)
            {
                Button btn = new Button() {Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};

                switch (item.TinhTrang1)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Yellow;
                        break;
                }

                btn.Text = item.MaPhong1 + Environment.NewLine + item.TinhTrang1;

              

                flowLayoutPanel1.Controls.Add(btn);

               
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

      
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            faccountprofile tt = new faccountprofile(LoginAccount);
           
            tt.ShowDialog();
        }

        private void fquanly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thinkingDataSet14.hienthiphong' table. You can move, or remove it, as needed.
            this.hienthiphongTableAdapter1.Fill(this.thinkingDataSet14.hienthiphong);
            // TODO: This line of code loads data into the 'thinkingDataSet13.hienthiphong' table. You can move, or remove it, as needed.
           // this.hienthiphongTableAdapter.Fill(this.thinkingDataSet13.hienthiphong);
            // TODO: This line of code loads data into the 'thinkingDataSet8.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.thinkingDataSet8.Phong);
            // TODO: This line of code loads data into the 'thinkingDataSet7.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter1.Fill(this.thinkingDataSet7.KhachHang);
            // TODO: This line of code loads data into the 'quanlyphongtroDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this.quanlyphongtroDataSet1.KhachHang);
            // TODO: This line of code loads data into the 'quanlyphongtroDataSet.Hoadon' table. You can move, or remove it, as needed.
            this.HoadonTableAdapter.Fill(this.quanlyphongtroDataSet.Hoadon);

            //this.reportViewerhoadon.RefreshReport();
        }

       /* private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fadmin admin = new fadmin();
            admin.ShowDialog();
        }*/

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.ShowDialog();
        }
  
        public SqlCommand com { get; set; }

        public string TenKhachHang { get; set; }
    }
}
