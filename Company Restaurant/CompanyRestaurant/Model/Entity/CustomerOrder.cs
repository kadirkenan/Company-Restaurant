using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class CustomerOrder:BaseEntity
    {
        public string AppUserId { get; set; }
        public int EmployeeId { get; set; }
        public string TableNo { get; set; }
        public int MenuId { get; set; }
        public bool Status { get; set; }
        public int Price { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual Employee Employee { get; set; }
        
        public int TableId { get; set; }
        
        public List<MenuProduct> MenuProducts { get; set; }
    }
}
