using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetAeroport.Models
{

    public class Vol
    {
        public string ID { get; set; }
        public string Destination { get; set; }
        public string Etat { get; set; }
        public string Logo { get; set; }
        public string Prevu { get; set; }
        public string Revise { get; set; }
        public string Porte { get; set; }
        public DateTime Date { get; set; }
        public string TypeVol { get; set; }

        public Vol(string iD, string destination, string etat, string logo, string prevu, string revise, string porte, DateTime date, string typevol)
        {
            ID = iD;
            Destination = destination;
            Etat = etat;
            Logo = logo;
            Prevu = prevu;
            Revise = revise;
            Porte = porte;
            Date = date;
            TypeVol = typevol;
        }

        public Vol()
        {
            ID = "";
            Destination = "";
            Etat = "";
            Logo = "";
            Prevu = "";
            Revise = "";
            Porte = "";
            Date = DateTime.Now;
            TypeVol = "";
        }

      
    }
}