using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class TableMenu:BaseEntity
    {
        public virtual Table Table { get; set; }
        public virtual MenuProduct MenuProduct { get; set; }
    }
}
