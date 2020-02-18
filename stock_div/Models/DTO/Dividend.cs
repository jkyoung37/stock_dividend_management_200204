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
    [Table("Dividend")]
    public class Dividend
    {
        public Dividend()
        {
        }

        public Dividend(Decimal price, DateTime date)
        {
            this.Price = price;
            this.CreateAt = date;
            this.User = Utilities.User.Email;
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("price")]
        public Decimal Price { get; set; }

        [Column("users")]
        public string User { get; set; }

        [Column("create_at")]
        public DateTime CreateAt { get; set; }
    }
}
