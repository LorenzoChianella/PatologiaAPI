using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAPIWeb
{
    [DataContract]
    public class Certificato : RootObject<Certificato>
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string codPaziente { get; set; }
        [DataMember]
        public string codMedico { get; set; }
        [DataMember]
        public string dataEmissione { get; set; }
        [DataMember]
        public string codPatologia { get; set; }
        [DataMember]
        public string dataInizio { get; set; }
        [DataMember]
        public string dataFine { get; set; }
        [DataMember]
        public string tipologia { get; set; }
        [DataMember]
        public string comune { get; set; }
        [DataMember]
        public string provincia { get; set; }
        [DataMember]
        public string indirizzo { get; set; }
        [DataMember]
        public string cap { get; set; }
        [DataMember]
        public string domicilio { get; set; }
        [DataMember]
        public string note { get; set; }
    }
}
