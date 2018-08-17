using System;
using System.Collections.Generic;

namespace DecreaseCommute.MvcClient.Models
{
    public partial class TravelUser
    {
        public TravelUser()
        {
            TravelPlan = new HashSet<TravelPlan>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<TravelPlan> TravelPlan { get; set; }
    }
}
