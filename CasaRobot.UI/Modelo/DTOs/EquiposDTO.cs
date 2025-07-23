using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Modelo.DTOs
{
      public class EquiposDTO

    {
        public int EquipoID { get; set; }

        public int? ClienteID { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }
    }
}
