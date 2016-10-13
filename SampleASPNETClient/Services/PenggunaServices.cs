using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RestSharp;
using SampleASPNETClient.Models;

namespace SampleASPNETClient.Services
{
    public class PenggunaServices
    {
        private RestClient _client;

        public PenggunaServices()
        {
            _client = new RestClient("http://localhost:52099/");
        }

        public void Register(RegisterBindingModel model)
        {
            RestRequest request = new RestRequest("api/Account/Register", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddBody(model);

            var response = _client.Execute(request);

            if(response.StatusCode!=System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage);
            }
        }
    }
}