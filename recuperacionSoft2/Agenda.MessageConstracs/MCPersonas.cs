using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageConstracs
{
    [WCF::MessageContract(IsWrapped = false)]
    public class MCPersonas
    {
        private DataConstracs.DCPersonas datosPersonas;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "DatosCliente")]
        public DataConstracs.DCPersonas DatosPersonas
        {
            get { return datosPersonas; }
            set { datosPersonas = value; }

        }
    }
}
