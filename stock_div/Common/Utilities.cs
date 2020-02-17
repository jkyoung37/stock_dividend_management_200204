using HtmlAgilityPack;
using stock_div.Models.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Windows.Forms;
using System.Xml;

namespace stock_div.Common
{
    public class Utilities
    {
        public static Form PreviousPage;

        public static Users User = new Users("jkyoung37@gmail.com", "3633270", "ast", "name",null);

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
            //DateTime format
            dgv.Columns["create_at"].DefaultCellStyle.Format = "yyyy/MM/dd";
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

        public static Decimal setRate(string country)
        {
            Dictionary<string, Decimal> result = new Dictionary<string, Decimal>();
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString("https://spot.wooribank.com/pot/Dream?withyou=FXCNT0002&rc=0&divType=6&lang=KOR");

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var cols = doc.DocumentNode.SelectNodes("//tbody/tr/td");
            for(int i = 0; i<cols.Count; i = i + 3)
            {
                string key = cols[i].InnerText.Trim();
                Decimal value = Decimal.Parse((cols[i+2].InnerText.Trim()).Replace(",",""));
                result.Add(key, value);
            }

            if (result.ContainsKey(country))
            {
                return result[country];
            }

            return 0M;
        }
    }
}
