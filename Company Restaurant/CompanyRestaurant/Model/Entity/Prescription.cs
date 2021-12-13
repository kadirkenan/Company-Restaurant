using DataAccess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Prescription:BaseEntity
    {
        public int MenuProductId { get; set; }
        public int StorageProductId { get; set; }
        public int GaugeId { get; set; }
        public string Ingridients { get; set; }
        public  List<Gauge> Gauges { get; set; }
        public List<StorageProduct> StorageProducts { get; set; }
        public virtual MenuProduct MenuProduct { get; set; }
       

    }
}
