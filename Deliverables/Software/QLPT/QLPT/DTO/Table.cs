using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
        public class Table
    {
        public Table(string MaPhong, string TinhTrang)
        {
            this.MaPhong1 = MaPhong;
            this.TinhTrang1 = TinhTrang;
        }

        public Table (DataRow row)
        {
            this.MaPhong1 = row["MaPhong"].ToString();
            this.TinhTrang1 = row["TinhTrang"].ToString();
        }

        private string TinhTrang;

        public string TinhTrang1
        {
            get { return TinhTrang; }
            set { TinhTrang = value; }
        }

        private string MaPhong;

        public string MaPhong1
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }
       
    }
}
