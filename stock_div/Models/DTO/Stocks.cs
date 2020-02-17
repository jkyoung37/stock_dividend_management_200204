using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stock_div.Common;
using System.ComponentModel;

namespace stock_div.Models.DTO
{
    [Table("Stocks")]
    public class Stocks
    {
        public Stocks()
        {
        }

        public Stocks(String symbol, Decimal shares, Decimal price)
        {
            this.Symbol = symbol;
            this.Price = price;
            this.Shares = shares;
            this.CreateAt = DateTime.Now;
            this.User = Utilities.User.Email;
            this.DeleteFlag = "0";
        }
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("symbol")]
        [Required]
        public String Symbol { get; set; }

        [Column("price")]
        [Required]
        public Decimal Price { get; set; }

        [Column("shares")]
        [Required]
        public Decimal Shares { get; set; }

        [Column("users")]
        public string User { get; set; }

        [Column("create_at")]
        public DateTime CreateAt { get; set; }

        [Column("delete_flag")]
        public string DeleteFlag { get; set; }

    }
}
