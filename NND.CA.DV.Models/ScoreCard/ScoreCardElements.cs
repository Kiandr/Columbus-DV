using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NND.CA.DV.Models.ScoreCard
{
    class ScoreCardElements
    {
        public Customers Customer { get; set; }
        public CustomerServices CustomerService { get; set; }
        public Employees Employee { get; set; }
        public Financial Financial { get; set; }
        public MultiUnitReporting MultiUnitReporting { get; set; }
    }
}
