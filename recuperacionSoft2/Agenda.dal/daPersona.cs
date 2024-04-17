using Agenda.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.dal
{
    public class daPersona
    {
        public bool insertaTipoCliente(BEClientes pCliente)
        {
            using (var bd = new turistas_software2Entities())
            {
                var per = new clientes();
                {
                    per.id_clientes = pCliente.idCliente;
                    per.nombres = pCliente.nombres;
                    per.edad = pCliente.edad;
                }
                bd.clientes.Add(per);
                bd.SaveChanges();
                return true;
            }
        }

        public bool actualizaTipoCliente(BEClientes pClientes)
        {
            using (var bd = new turistas_software2Entities())
            {
                try
                {
                    var cliente = bd.clientes.First(s => s.id_clientes == pClientes.idCliente);
                    cliente.nombres =pClientes.nombres;
                    cliente.edad = pClientes.edad;              
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool eliminarClientes(int ID_CLIENTE)
        {
            using (var bd = new turistas_software2Entities())
            {
                var per = bd.clientes.First(s => s.id_clientes == ID_CLIENTE);
                bd.clientes.Remove(per);
                bd.SaveChanges();
                return true;
            }
        }
        public BEClientes seleccionaTipoCliente(int ID)
        {
            using (var bd = new turistas_software2Entities())
            {
                var pEstudiante = bd.clientes.FirstOrDefault(s => s.id_clientes == ID);

                if (pEstudiante == null)
                {
                    return null;
                }

                var per = new BEClientes();
                per.idCliente = pEstudiante.id_clientes;
                per.nombres = pEstudiante.nombres;
                per.edad = pEstudiante.edad;
                return per;
            }
        }
    }
}
