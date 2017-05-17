using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAPIWeb
{
    // Oggetto Generico che contiene la data di sistema, il totale degli oggetti, 
    //la lista degli oggetti(generici), e il numero di oggetti in essa contenuti.
    [DataContract]
    public class RootObject<T>
    {
        [DataMember] 
        public string datetime { get; set; }
        [DataMember]
        public int total { get; set; }
        [DataMember]
        public List<T> data { get; set; }
        [DataMember]
        public int items { get; set; }
    }
}
