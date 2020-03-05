using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models.DAO
{
    public class DAOFilms : IDAOFilms
    {
        public List<Films> Retreive()
        {
            List<Films> v = new List<Films>();

            v.Add(new Films { titre = "Forrest Gump", genre = "Drame", duree = "1h30", prix = 149.10 });
            v.Add(new Films { titre = "La Ligne verte",genre=  "Policier", duree = "1h50", prix =114.99 });
            v.Add(new Films { titre = "La Liste de Schindler", genre = "Guerre", duree = "2h00", prix = 176.87 });
            v.Add(new Films { titre = "12 hommes en colère", genre = "Animation", duree = "3h10", prix = 14.15 });
            v.Add(new Films { titre = "Your Name", genre = " Fantastique", duree = "1h00", prix = 141.12 });

            return v;
        }
    }
}