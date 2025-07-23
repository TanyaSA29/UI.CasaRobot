using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Modelo.DTOs
{
    public class HistorialServiciosDTO
    {
        public int HistorialID { get; set; }

        public int? OrdenID { get; set; }

        public int? EmpleadoID { get; set; }

        public string DescripcionTrabajo { get; set; }
    }
}
