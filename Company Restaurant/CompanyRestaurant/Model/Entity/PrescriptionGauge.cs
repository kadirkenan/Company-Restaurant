using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class PrescriptionGauge:BaseEntity 
    {
        public virtual Gauge Gauge { get; set; }
        public virtual Prescription Prescription { get; set; }
    }
}
