using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Modelo.DTOs
{
    public class OrdenesServicioDTO
    {
        public int OrdenID { get; set; }

        public int? EquipoID { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public int? EstadoID { get; set; }

        public string DescripcionProblema { get; set; }

        public DateTime? FechaSalida { get; set; }
    }
}
