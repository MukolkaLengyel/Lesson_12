using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_HW
{
    internal interface ICustomer
    {
        public string CustomerFirstName { get; set; }
        public string CustomerMidlleName { get; set; }
        public string CustomerSecondName { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerAddress { get; set; }
    }
}
