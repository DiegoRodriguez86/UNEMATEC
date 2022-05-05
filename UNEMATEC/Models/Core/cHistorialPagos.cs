using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNEMATEC.Models.ViewModels;

namespace UNEMATEC.Models.Core
{
    public class cHistorialPagos
    {
        public mHistorialPagos GetHistorialPago(string IdPayPal)
        {
            var client = new RestClient("https://api-m.sandbox.paypal.com/v1/billing/subscriptions/"+IdPayPal+"/transactions?start_time=2018-01-21T07:50:20.940Z&end_time=2022-05-02T07:50:20.940Z");
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("authorization", "Bearer AlVZbyzcmdxt9F4QCE48d3xBNTS5Aq83viZHNSETtbs8cROnQfA8AOWB");
            IRestResponse response = client.Execute(request);
            var lista = Newtonsoft.Json.JsonConvert.DeserializeObject<mHistorialPagos>(response.Content);
            return lista;
        }
    }
}