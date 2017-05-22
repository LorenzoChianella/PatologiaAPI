using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAPIWeb
{
    public class ApiRestClient : JSONManager
    {
        private static WebClient syncClient = new WebClient();

        public static RootObject<Paziente> GetPazientiDataFromServer()
        {
            string url = "http://192.168.4.104:8080/ApiServer/Paziente/all";
            string jsonPazienti = "";

            try
            {
                jsonPazienti = syncClient.DownloadString(url);
                RootObject<Paziente> json = DeserializeJson<RootObject<Paziente>>(jsonPazienti);

                return json;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static RootObject<Patologia> GetPatologieDataFromServer()
        {
            string url = "http://192.168.4.104:8080/ApiServer/Patologia/all";
            string jsonPatologie = "";

            try
            {
                jsonPatologie = syncClient.DownloadString(url);
                RootObject<Patologia> json = DeserializeJson<RootObject<Patologia>>(jsonPatologie);

                return json;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static RootObject<Certificato> GetCertificatiDataFromServer()
        {
            string url = "http://192.168.4.104:8080/ApiServer/Certificato/all";
            string jsonCertificati = "";

            try
            {
                jsonCertificati = syncClient.DownloadString(url);
                RootObject<Certificato> json = DeserializeJson<RootObject<Certificato>>(jsonCertificati);

                return json;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static RootObject<Medico> GetMediciDataFromServer()
        {
            string url = "http://192.168.4.104:8080/ApiServer/Medico/all";
            string jsonMedici = "";

            try
            {
                jsonMedici = syncClient.DownloadString(url);
                RootObject<Medico> json = DeserializeJson<RootObject<Medico>>(jsonMedici);

                return json;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //public static bool SendCertificatiToServer(List<Certificato> cList)
        //{
        //    var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://url");
        //    httpWebRequest.ContentType = "application/json";
        //    httpWebRequest.Method = "POST";  



        //    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //    {
        //        var result = streamReader.ReadToEnd();
        //    }

        //    return true;
        //}

        public static void DeletePatologia(string s)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.4.104:8080/ApiServer/Patologia/delete/" + s);
            httpWebRequest.Method = "DELETE";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        }

        public static void SendPatologiaToServer(Patologia p) {

            Patologia tmpPat = new Patologia();

            //TODO: Associare il contenuto delle txtBox ai campi della patologia.
            //Chiamare il Serializzatore
            //Inviare il Json della nuova Patologia
            
        }

        public static void DeletePaziente(string s)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.4.104:8080/ApiServer/Paziente/delete/" + s);
            httpWebRequest.Method = "DELETE";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        }

        public static void DeleteMedico(string s)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.4.104:8080/ApiServer/Medico/delete/" + s);
            httpWebRequest.Method = "DELETE";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        }
    }
}
