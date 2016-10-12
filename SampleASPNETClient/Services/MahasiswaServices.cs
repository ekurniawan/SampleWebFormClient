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
    }
}