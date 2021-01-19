using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNAPTestWeb.Models
{
    public class PersonModel
    {
        public bool IsMinor { get; set; }
        public bool HasIncome { get; set; }
        public bool HasResources { get; set; }
        public List<decimal> Income { get; set; }
        public decimal Resources { get; set; }

    }
}
