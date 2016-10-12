using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RestSharp;
using SampleASPNETClient.Models;

namespace SampleASPNETClient.Services
{
    public class MahasiswaServices
    {
        private RestClient _client;

        public MahasiswaServices()
        {
            _client = new RestClient("http://localhost:52099/");
        }

        public IEnumerable<Mahasiswa> GetAll()
        {
            RestRequest request = new RestRequest("api/Mahasiswa", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            var response = _client.Execute<List<Mahasiswa>>(request);

            if(response.StatusCode==System.Net.HttpStatusCode.OK)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public void Post(Mahasiswa mhs)
        {
            RestRequest request = new RestRequest("api/Mahasiswa", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddBody(mhs);

            var response = _client.Execute(request);

            if(response.StatusCode!=System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage);
            }
        }
    }
}