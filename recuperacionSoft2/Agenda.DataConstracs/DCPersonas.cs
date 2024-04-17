using System;
using System.Net;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Agenda.DataConstracs
{
    [WcfSerialization::DataContract(Namespace = "http://agenda.datacontracts", Name = "Clientes")]
    public partial class DCPersonas
    {
        private int id;
        private string nombres;
        private int edad;

        [WcfSerialization::DataMember(Name = "Idclientes", IsRequired = true, Order = 0)]
        public int Idclientes
        {
            get { return id; }
            set { id = value; }
        }



        [WcfSerialization::DataMember(Name = "Nombres", IsRequired = true, Order = 1)]
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }



        [WcfSerialization::DataMember(Name = "Edad", IsRequired = false, Order = 2)]
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
