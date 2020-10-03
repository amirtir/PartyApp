using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyApp.Models
{
    public static class Repository
    {
        public static List<Guest> Guests=new List<Guest>();

        public static void Insert(Guest guest)
        {
            Guests.Add(guest);
        }
    }
}
