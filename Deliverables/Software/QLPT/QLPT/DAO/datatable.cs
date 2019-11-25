using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLPT.DAO
{
    class datatable
    {
        private string query;

        public datatable(string query)
        {
            // TODO: Complete member initialization
            this.query = query;
        }
        public IEnumerable<DataRow> row { get; set; }

        public IEnumerable<System.Data.DataRow> rows { get; set; }

        public IEnumerable<System.Data.DataRow> Rows { get; set; }
    }
}
