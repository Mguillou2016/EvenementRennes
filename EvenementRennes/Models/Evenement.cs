using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvenementRennes.Models
{
    public class Evenement
    {
        public Evenement(Guid iD, string lieu, DateTime date, TimeSpan duree, string theme, string descriptif, List<string> images)
        {
            ID = iD;
            this.lieu = lieu;
            this.date = date;
            this.duree = duree;
            this.theme = theme;
            this.descriptif = descriptif;
            this.images = images;
        }

        public Guid ID { get; set; }
        public string lieu { get; set; }
        public DateTime date { get; set; }
        public TimeSpan duree { get; set; }
        public string theme { get; set; }
        public string descriptif { get; set; }
        public List<string> images { get; set; }

       
    }
}