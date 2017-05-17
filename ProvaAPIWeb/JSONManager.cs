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


        public static void SerializeJson(List<Certificato> cList, HttpWebRequest request)
        {
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //string json = new JavaScriptSerializer().Serialize(new
                //{
                //    user = "Foo",
                //    password = "Baz"
                //});

                string json = "{\"user\":\"test\"," +
                  "\"password\":\"bla\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }
    }
}
