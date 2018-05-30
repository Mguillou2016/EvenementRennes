using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvenementRennes.Models
{
    public class Parking
    {
        public Dictionary<string, string> etats { get; set; }
        public string geolocalisation { get; set; }
        
    }
}