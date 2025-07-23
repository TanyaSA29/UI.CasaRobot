using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Modelo.DTOs
{
    public class Notificacionesdto

    {
        public int NotificacionID { get; set; }

        public int? ClienteID { get; set; }

        public DateTime? FechaEnvio { get; set; }

        public string TipoNotificacion { get; set; }

        public string Detalle { get; set; }
    }
}
