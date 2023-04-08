using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_HW
{
    internal interface ISeller
    {
        public string SellerFirstName { get; set; }
        public string SellerMidlleName { get; set; }
        public string SellerSecondName { get; set; }
        public int SellerAge { get; set; }
        public string SellerCompanyName { get; set; }
    }
}