using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_SQLite.Model
{
    public class User
    {
        [Key]

        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
    }
}
