﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.be
{
    public class BELugarVisita
    {
      
            public int idlugarVisita { get; set; }
            public string nombre { get; set; }

            public int tipoCliente { get; set; }
            public int precio { get; set; }


            public override string ToString()
            {
            return idlugarVisita + ", " + nombre + "," + tipoCliente + "," + precio;
            }
       
    }
}
