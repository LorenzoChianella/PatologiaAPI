﻿using System;
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
        public string note { get; set; }
        [DataMember]
        public string cod_medico { get; set; }
        [DataMember]
        public string cod_patologia { get; set; }
        [DataMember]
        public string data_emissione { get; set; }
        [DataMember]
        public string indirizzo { get; set; }
        [DataMember]
        public string data_inizio { get; set; }
        [DataMember]
        public string provincia { get; set; }
        [DataMember]
        public string idCertificato { get; set; }
        [DataMember]
        public string tipologia { get; set; }
        [DataMember]
        public string domicilio { get; set; }
        [DataMember]
        public string CAP { get; set; }
        [DataMember]
        public string comune { get; set; }
        [DataMember]
        public string cod_sanitario { get; set; }
        [DataMember]
        public string data_fine { get; set; }
    }
}
