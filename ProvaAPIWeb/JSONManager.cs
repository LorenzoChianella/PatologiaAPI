using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAPIWeb
{
    public class JSONManager
    {
        //Funzione che deserializza il JSON che arriva dall'API Server (che contiene i dati dal DataBase
        public static T DeserializeJson<T>(string json)
        {
            T result;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                result = (T)serializer.ReadObject(ms);
            }
            return result;
        }

        //Serializza i dati dellein JSON e li invia al server
        public static string SerializeJson<T>(T t)
        //{
        //    string json = "{\"+cod_patologia\":\"" + p.cod_patologia + "\"," +
        //                   "\"nome\":\"" + p.nome + "\"," +
        //                   "\"descrizione\":\"" + p.descrizione +"\"}";
        //    return json;
        //}
        { 
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
        MemoryStream ms = new MemoryStream();
        serializer.WriteObject(ms, t);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
    }
}

