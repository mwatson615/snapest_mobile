using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNAPTestWeb.Models
{
    public class HouseholdModel
    {
        public List<PersonModel> HouseholdMemberList { get; set; }
        public DemographicModel HHDemographic { get; set; }
        public bool PaysShelterCosts { get; set; }
        public bool PaysUtilities { get; set; }
        public decimal TotalHHIncome { get; set; }
        public decimal TotalHHResources { get; set; }
        public decimal ShelterCosts { get; set; }
        public decimal Benefit { get; set; }

    }
}
