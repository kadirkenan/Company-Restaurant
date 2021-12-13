using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            ActivationCode = Guid.NewGuid();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Role { get; set; }

       
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ActivationCode { get; set; }

        public string EmployeeEmail { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
