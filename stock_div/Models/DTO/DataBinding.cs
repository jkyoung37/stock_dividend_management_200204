using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_div.Models.DTO
{
    class DataBinding
    {
        public string Select { get; set; }
        public int Id { get; set; }
        public string Symbol { get; set; }
        public Decimal Shares { get; set; }
        public DateTime CreateAt { get; set; }
        public Decimal Price { get; set; }
    }
}
