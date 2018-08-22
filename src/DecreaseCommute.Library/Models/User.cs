using System;
using System.Collections.Generic;
using System.Text;

namespace DecreaseCommute.Library.Models
{
    public class TravelUser
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
