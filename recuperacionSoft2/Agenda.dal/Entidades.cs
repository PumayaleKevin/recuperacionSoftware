using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.dal
{
    public partial class Entidades
    {
        public int idCliente { get; set; }
        public string nombres { get; set; }
        public int edad { get; set; }


    }

    public partial class lugarVisita {
        public int idlugarVisita { get; set; }
        public string nombre { get; set; }

        public int tipoCliente { get; set; }
        public int precio { get; set; }

    }

}
