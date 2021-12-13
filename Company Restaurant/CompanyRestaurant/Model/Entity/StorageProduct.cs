using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class StorageProduct:BaseEntity
    {
        public string StorageProductName { get; set; }
        public int SupplierId { get; set; }
        public int StorageCategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsOnOrder { get; set; }
        public short UnitsInStock { get; set; }
        public string ProductImagePath { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual StorageCategory StorageCategory { get; set; }


    }
}
