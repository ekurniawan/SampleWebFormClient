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

        public ProfilPengguna GetLogin(string username,string password)
        {
            RestRequest request = new RestRequest("Token", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("Content-Type", 
                "application/x-www-form-urlencoded;charset=UTF-8;");
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", username);
            request.AddParameter("password", password);

            var response = _client.Execute<ProfilPengguna>(request);

            return response.Data;
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