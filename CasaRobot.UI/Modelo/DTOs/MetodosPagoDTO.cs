using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Modelo.DTOs
{
    public class MetodosPagoDTO
    {
        public int PagoID { get; set; }

        public int? OrdenID { get; set; }

        public string Metodo { get; set; }

        public DateTime? FechaPago { get; set; }

    }
}
