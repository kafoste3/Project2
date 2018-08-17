using System;
using System.Collections.Generic;

namespace DecreaseCommute.MvcClient.Models
{
    public partial class TravelPlan
    {
        public string PlanId { get; set; }
        public string UserName { get; set; }
        public string SourceStation { get; set; }
        public string DestinationStation { get; set; }

        public TravelUser UserNameNavigation { get; set; }
    }
}
