using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Role")]
    public class Role : IEntity
    {
        [Key]
        [Column("roleID")]
        public int roleID { get; set; }
        [Column("name")]
        public string name { get; set; }
    }
}
