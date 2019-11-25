using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class BillDetail
    {
        public string MaHD { get; set; }
        public string MaKH {get; set;}
        public string MaPhong { get; set; }
        public int SoChuDien { get; set; }
        public double TienDien { get; set; }
        public int SoChuNuoc { get; set; }
        public double TienNuoc { get; set; }
        public int TienPhong { get; set; }
        public string TongTien { get { return String.Format("0$", TienDien + TienNuoc + TienPhong); } }
        public DateTime NgayLapHD { get; set; }




    }
}
