using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.be
{
    public class BEClientes
    {
        public int idCliente { get; set; }
        public string nombres { get; set; }
        public int edad { get; set; }

        public override string ToString()
        {
            return idCliente + ", " + nombres + "," + edad;
        }
    }




}
