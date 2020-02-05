using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;        
using System.ComponentModel.DataAnnotations.Schema;

namespace stock_div.Models.DTO
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("create_at")]
        public DateTime CreateAt { get; set; }

        [Column("delete_at")]
        public DateTime? DeleteAt { get; set; }

    }
}
