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
    public partial class FPrint : Form
    {
        public FPrint()
        {
            InitializeComponent();
        }

        private void FPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thinkingDataSet6.Hoadon' table. You can move, or remove it, as needed.
            this.HoadonTableAdapter.Fill(this.thinkingDataSet6.Hoadon);

            this.reportViewer1.RefreshReport();
        }
    }
}
