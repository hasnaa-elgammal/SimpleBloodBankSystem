using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_life.classes
{
    class BloodOrderClass
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalNumber { get; set; }
        public string MobileNumber { get; set; }
        public int BloodGroup { get; set; }
        public int Units { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
