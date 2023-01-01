using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.Models
{
    public class WithdrawViewModel
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
