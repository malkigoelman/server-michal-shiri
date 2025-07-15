using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core.Entitis
{
    namespace smr.Core.Models
    {
        public enum UserRole
        {
            Renter,  // משכיר
            Tourist  // שוכר
        }

        public class User
        {
            [Key]
            public string Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; } 
            public virtual UserRole Role { get; set; } // תפקיד המשתמש (משכיר/שוכר)
        }
    }
}
