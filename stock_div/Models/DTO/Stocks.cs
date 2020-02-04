using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_div.Models.DTO
{
    [Table("Stocks")]
    public class Stocks
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("symbol")]
        [Required]
        public string Symbol { get; set; }

        [Column("price")]
        [Required]
        public string Price { get; set; }

        [Column("shares")]
        [Required]
        public string Shares { get; set; }

        [Column("create_at")]
        public DateTime CreateAt { get; set; }

        [Column("delete_at")]
        public DateTime? DeleteAt { get; set; }

        [Column("delete_flag")]
        public int? DeleteFlag { get; set; }

    }
}
