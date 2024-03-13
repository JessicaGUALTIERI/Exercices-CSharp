using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SubscriptionToNewspaper
{
    internal static class DataBase
    {
        public static List<User> Users { get; set; }

        public static void Initialize()
        {
            Users = new List<User>();
        }
    }
}
