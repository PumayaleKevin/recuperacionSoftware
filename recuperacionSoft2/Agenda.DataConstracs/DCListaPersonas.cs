using System;
using System.Collections.Generic;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Agenda.DataConstracs
{
    [WcfSerialization::CollectionDataContract(Namespace = "http://agenda.datacontracts")]
    public class DCListaPersonas : List<DCPersonas>
    {
    }
}
