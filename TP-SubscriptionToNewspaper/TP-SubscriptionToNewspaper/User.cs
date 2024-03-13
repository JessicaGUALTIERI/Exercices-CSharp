using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SubscriptionToNewspaper
{
    internal class User
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public SubscriptionDuration Duration { get; set; }
        public bool Newsletter { get; set; }
    }
}
