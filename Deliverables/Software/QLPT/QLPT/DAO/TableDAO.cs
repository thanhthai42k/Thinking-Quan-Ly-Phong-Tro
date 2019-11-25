using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class TableDAO

    {
        public static int TableWidth = 80;
        public static int TableHeight = 80;

        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO(){}

        public List<Table> LoadTableList() 
        {
            List<Table> TableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExcuteQuery("pGetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                TableList.Add(table);
            }

            return TableList;
        }
    }
}
