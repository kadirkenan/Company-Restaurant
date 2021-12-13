using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Table : BaseEntity
    {


        public string TableNo { get; set; }
        public DateTime CloseDate { get; set; }
        public int EmployeeId { get; set; }


    }
}