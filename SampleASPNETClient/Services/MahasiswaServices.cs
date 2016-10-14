using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RestSharp;
using SampleASPNETClient.Models;
using System.Threading.Tasks;

namespace SampleASPNETClient.Services
{
    public class MahasiswaServices
    {
        private RestClient _client;

        public MahasiswaServices()
        {
            _client = new RestClient("http://localhost:52099/");
        }

        public IEnumerable<Mahasiswa> GetAll(string access_token)
        {
            RestRequest request = new RestRequest("api/Mahasiswa", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", access_token));

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

        public void Post(Mahasiswa mhs, string access_token)
        {
            RestRequest request = new RestRequest("api/Mahasiswa", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", access_token));
            request.AddBody(mhs);

            var response = _client.Execute(request);

            if(response.StatusCode!=System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public Mahasiswa GetById(string id, string access_token)
        {
            RestRequest request = new RestRequest("api/Mahasiswa", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", access_token));
            request.AddParameter("id", id, ParameterType.QueryString);

            var response = _client.Execute<Mahasiswa>(request);
            if(response.StatusCode==System.Net.HttpStatusCode.OK)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }


        public IEnumerable<Mahasiswa> GetByNama(string nama, string access_token)
        {
            RestRequest request = new RestRequest(string.Format("api/Mahasiswa/GetByNama/{0}", nama), Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", access_token));

            var response = _client.Execute<List<Mahasiswa>>(request);

            return response.Data;
            
        }

        public void Put(string id,Mahasiswa mhs, string access_token)
        {
            //RestRequest request = new RestRequest(string.Format("api/Mahasiswa/{0}",id), Method.PUT)
            //{
            //    RequestFormat = DataFormat.Json
            //};

            RestRequest request = new RestRequest("api/Mahasiswa", Method.PUT)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", access_token));
            request.AddParameter("id", id,ParameterType.QueryString);
            request.AddBody(mhs);
            
            var response = _client.Execute(request);

            if(response.StatusCode!=System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public void Delete(string id, string access_token)
        {
            RestRequest request = new RestRequest("api/Mahasiswa", Method.DELETE)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", access_token));
            request.AddParameter("id", id, ParameterType.QueryString);

            var response = _client.Execute(request);

            if(response.StatusCode!=System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data not found !");
            }
        }
    }
}