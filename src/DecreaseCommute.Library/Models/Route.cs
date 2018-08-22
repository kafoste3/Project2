using System;
using System.Collections.Generic;
using System.Text;

namespace DecreaseCommute.Library.Models
{
    public class TravelPlan
    {
        public string PlanId { get; set; }
        public string UserName { get; set; }
        public string SourceStation { get; set; }
        public string DestinationStation { get; set; }

        public TravelUser UserNameNavigation { get; set; }

    }
}
