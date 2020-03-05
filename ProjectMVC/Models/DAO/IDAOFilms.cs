using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Models.DAO
{
    interface IDAOFilms
    {
        List<Films> Retreive();
    }
}
