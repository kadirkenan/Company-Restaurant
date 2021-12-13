using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class StorageCategory:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Picture { get; set; }
    }
}
