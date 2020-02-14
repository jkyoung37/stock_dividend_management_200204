using stock_div.Models.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_div.Common
{
    public class Utilities
    {
        public static Form PreviousPage;

        public static Users User = new Users("test@gmail.com", "1234", "last_name", "first_name", null);

        public static void setDataGridViewOption(DataGridView dgv)
        {
            //Not allow size modify
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            //Column 
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //Header
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Set Font
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            //Show Dollar
            if (dgv.Columns["price"] != null)
            {
                dgv.Columns["price"].DefaultCellStyle.Format = "$0.00";
            }
            if (dgv.Columns["price2"] != null)
            {
                dgv.Columns["price2"].DefaultCellStyle.Format = "$0.00";
            }

        }
        public static void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);

            }
        }
    }
}
