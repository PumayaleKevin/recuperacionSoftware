using Agenda.be;
using Agenda.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.bll
{
    public class blAgenda
    {
        public bool insertaTipoCliente(BEClientes pCliente)
        {
            var dataAccess = new daPersona();
            // aqui la logica de negocio
            if (pCliente.idCliente == 3)
                return false;
            return dataAccess.insertaTipoCliente(pCliente);
        }

        public bool actualizaTipoCliente(BEClientes pCliente)
        {
            var dataAccess = new daPersona();
            // aqui la logica de negocio
            if (pCliente.idCliente == 3)
                return false;
            return dataAccess.actualizaTipoCliente(pCliente);
        }

        public bool eliminarClientes(int pIdCliente)
        {
            var dataAccess = new daPersona();
            // aqui la logica de negocio
            if (pIdCliente == 1)
                return false ;
            dataAccess.eliminarClientes(pIdCliente);
            return true;
        }
        public BEClientes seleccionaTipoCliente(int pCodigo)
        {
            var dataAccess = new daPersona();
            return dataAccess.seleccionaTipoCliente(pCodigo);
        }
    }
}
