using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurDuzceEduTr.Models.Entities
{
    [Table("Users")]
    public class Users:IdentityUser
    {
        //[Key]
        //public int UserId { get; set; } = default(int);
        //public string UserName { get; set; }
        //public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
