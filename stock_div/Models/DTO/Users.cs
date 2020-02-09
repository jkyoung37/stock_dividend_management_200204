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
        public Users()
        {
        }

        public Users(string email, string password, string last_name, string first_name, DateTime? create_at)
        {
            this.Email = email;
            this.Password = password;
            this.LastName = last_name;
            this.FirstName = first_name;
            if (create_at.HasValue)
            {
                this.CreateAt = create_at.Value;
            }
            else
            {
                this.CreateAt = DateTime.Now;
            }
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("create_at")]
        public DateTime CreateAt { get; set; }

        [Column("delete_at")]
        public DateTime? DeleteAt { get; set; }

    }
}
