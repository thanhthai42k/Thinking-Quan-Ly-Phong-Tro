using QLPT.DAO;
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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thinkingDataSet12.updateDT' table. You can move, or remove it, as needed.
            this.updateDTTableAdapter.Fill(this.thinkingDataSet12.updateDT);
            // TODO: This line of code loads data into the 'thinkingDataSet6.Hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.thinkingDataSet6.Hoadon);
            // TODO: This line of code loads data into the 'thinkingDataSet5.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.thinkingDataSet5.TaiKhoan);
            // TODO: This line of code loads data into the 'thinkingDataSet4.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.thinkingDataSet4.Phong);
            // TODO: This line of code loads data into the 'thinkingDataSet3.HopDong' table. You can move, or remove it, as needed.
            this.hopDongTableAdapter.Fill(this.thinkingDataSet3.HopDong);
            // TODO: This line of code loads data into the 'thinkingDataSet2.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.thinkingDataSet2.KhachHang);
            // TODO: This line of code loads data into the 'thinkingDataSet1.ChiPhi' table. You can move, or remove it, as needed.
            this.chiPhiTableAdapter.Fill(this.thinkingDataSet1.ChiPhi);
            // TODO: This line of code loads data into the 'thinkingDataSet.DoanhThu' table. You can move, or remove it, as needed.
            //this.DoanhThuTableAdapter.Fill(this.thinkingDataSet.DoanhThu);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void btnthemkhachhang_Click(object sender, EventArgs e)

        {
            khachHangBindingSource.AddNew();
           // if (txtmakh.Text != "" & txttenkh.Text != "" & dtpkngaysinhkh.Text != "" & ckbnam.Text != "" & ckbnu.Text != "" & txtcmnd.Text != "" & txtdiachi.Text != "" & txtsdt.Text != "")
           
        }
       /* public void HienThi()
        {
            string sqlSelect = "select * from ChiPhi";
            SqlCommand cmd = new SqlCommand(sqlSelect, connection);
            SqlDataReader dr = new SqlDataReader();
            DataTable data = new DataTable();
            data.Load(dr);
            dtgvhienthichiphi.DataSource = data;

        }
        private void btnthemcp_Click(object sender, EventArgs e)
        {
            string Insert = "insert into ChiPhi values (@MaCP, MaPhong, @TenCP, @ThoiGian, @SoTien)";
            SqlCommand cmd = new SqlCommand(Insert, connection);
            cmd.Parameters.Add("MaChiPhi",txtmachiphi.Text);
            cmd.Parameters.Add("MaPhong", txtmaphongcp.Text);
            cmd.Parameters.Add("TenCP", txttenchiphi.Text);
            cmd.Parameters.Add("ThoiGian", txtthoigian.Text);
            cmd.Parameters.Add("SoTien", txtsotiencp.Text);
            cmd.ExecuteNonQuery();
            HienThi();

        }*/

       

        public SqlConnection connection { get; set; }

        private void btnthemcp_Click(object sender, EventArgs e)
        {
            chiPhiBindingSource.AddNew();
           
        }

        private void btnluucp_Click(object sender, EventArgs e)
        {
           
            chiPhiBindingSource.EndEdit();
            chiPhiTableAdapter.Update(thinkingDataSet1.ChiPhi);
            MessageBox.Show("Update thành công");
           
        }

        private void btnxoacp_Click(object sender, EventArgs e)
        {
            chiPhiBindingSource.RemoveCurrent();
        }

        private void btnthemhoadon_Click(object sender, EventArgs e)
        {
            hoadonBindingSource.AddNew();
        }

        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            hoadonBindingSource.EndEdit();
            hoadonTableAdapter.Update(thinkingDataSet6.Hoadon);
            MessageBox.Show("Update thành công");
        }

        private void btnluukhachhang_Click(object sender, EventArgs e)
        {
            khachHangBindingSource.EndEdit();
            khachHangTableAdapter.Update(thinkingDataSet2.KhachHang);
        }

        private void btnxoakhachhang_Click(object sender, EventArgs e)
        {
            khachHangBindingSource.RemoveCurrent();
        }

        private void btnthemhopdong_Click(object sender, EventArgs e)
        {
            hopDongBindingSource.AddNew();
            
        }

        private void btnluuhopdong_Click(object sender, EventArgs e)
        {
            hopDongBindingSource.EndEdit();
            hopDongTableAdapter.Update(thinkingDataSet3.HopDong);
        }

        private void btnxoahopdong_Click(object sender, EventArgs e)
        {
            hopDongBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            phongBindingSource.AddNew();
        }

        private void luuphong_Click(object sender, EventArgs e)
        {
            phongBindingSource.EndEdit();
            phongTableAdapter.Update(thinkingDataSet4.Phong);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phongBindingSource.RemoveCurrent();
        }

        private void btnthemtk_Click(object sender, EventArgs e)
        {
            taiKhoanBindingSource.AddNew();
        }

        private void btnluutaikhoan_Click(object sender, EventArgs e)
        {
            taiKhoanBindingSource.EndEdit();
            taiKhoanTableAdapter.Update(thinkingDataSet5.TaiKhoan);
        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {
            taiKhoanBindingSource.RemoveCurrent();
        }

        private void btnxoahoadon_Click(object sender, EventArgs e)
        {
            hoadonBindingSource.RemoveCurrent();
        }

        private void txtsotien_Click(object sender, EventArgs e)
        {

        }

        private void txttenchiphi_TextChanged(object sender, EventArgs e)
        {

        }


          private void fillByToolStripButton_Click(object sender, EventArgs e)
          {
              try
              {
                  this.hoadonTableAdapter.FillBy(this.thinkingDataSet6.Hoadon);
              }
              catch (System.Exception ex)
              {
                  System.Windows.Forms.MessageBox.Show(ex.Message);
              }

          }
        public void TimKiemKH ()
          {
              SqlConnection connection = new SqlConnection();
            //query số 1
              string query = "select * from KhachHang where TenKhachHang like N'%"+txttimkiemkh.Text+"%' ";

              dtgvhienthithongtinkh.DataSource = DataProvider.Instance.ExcuteQuery(query);
          }
          private void btntimkiemkh_Click(object sender, EventArgs e)
          {
              if (txttimkiemkh.Text.Trim()==""){
                  MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
              }
              else 
              {
                  TimKiemKH();
              }
              
          }

          private void btnreset_Click(object sender, EventArgs e)
          {
              dtgvhienthithongtinkh.DataSource = khachHangBindingSource;
          }

          private void btnin_Click(object sender, EventArgs e)
          {
              FPrint f = new FPrint();
              f.ShowDialog();
             
          }
        
        

         /* private Dim InputBox(string p1, string p2)
          {
              throw new NotImplementedException();
          }

          private Dim InputBox(string p)
          {
              throw new NotImplementedException();
          }
          */

    }
}
