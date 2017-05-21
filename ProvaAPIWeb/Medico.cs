using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProvaAPIWeb
{
    [DataContract]
    public class Medico: RootObject<Medico>
    {
        [DataMember]
        public string nome { get; set; }
        [DataMember]
        public string cognome { get; set; }
        [DataMember]
        public string luogoNascita { get; set; }
        [DataMember]
        public string dataNascita { get; set; }
        [DataMember]
        public string codiceFiscale { get; set; }
        [DataMember]
        public string residenza { get; set; }
        [DataMember]
        public string provincia { get; set; }
        [DataMember]
        public string indirizzo { get; set; }
        [DataMember]
        public string telefono { get; set; }
        [DataMember]
        public string cellulare { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string codiceAlbo { get; set; }
        [DataMember]
        public string codiceMedico { get; set; }
        

    }
}