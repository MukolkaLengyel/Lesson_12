using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_HW
{
    internal interface IOrder
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public DateTime Date_Time { get; set; }
        public string CustomerName { get; set; }
    }
}
