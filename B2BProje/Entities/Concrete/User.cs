using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Users")]
    public class User : IEntity
    {
        [Key]
        [Column("userID")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("phonenumber")]
        public string phonenumber { get; set; }
        [Column("address")]
        public string address { get; set; }

        [Column("roleID")]
        public int roleID { get; set; }

       
    }
}
