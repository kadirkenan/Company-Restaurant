using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class MenuProduct:BaseEntity
    {
        public string MenuName { get; set; }
        public bool Selected { get; set; }
        public int MenuCategoryId { get; set; }
        public string Description { get; set; }
        public int MenuPrice { get; set; }
        public bool StockStatus { get; set; }
        public string MenuImagePath { get; set; }
        public int Unit { get; set; }
        public int StorageProductUnits { get; set; }
        public virtual MenuCategory MenuCategory { get; set; }
    }
}
