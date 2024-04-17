using System;
using WCF = global::System.ServiceModel;


namespace Agenda.MessageConstracs
{
    [WCF::MessageContract(IsWrapped = false)]
    public class MCListaPersonas
    {
        private DataConstracs.DCListaPersonas clientes;

        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "Clientes")]
        public DataConstracs.DCListaPersonas Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

    }
}
