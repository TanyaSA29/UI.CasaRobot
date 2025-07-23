using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Modelo.DTOs
{
    public partial class Costos
    {
        public int CostoID { get; set; }

        public int? OrdenID { get; set; }

        public string DetalleCosto { get; set; }

    }
}
