using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
   public class PrescriptionStorageProduct:BaseEntity
    {
        public virtual Prescription Prescription { get; set; }
        public virtual StorageProduct StorageProduct { get; set; }
    }
}
