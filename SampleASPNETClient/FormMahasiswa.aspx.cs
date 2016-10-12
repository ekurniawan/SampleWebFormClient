using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SampleASPNETClient.Models;
using SampleASPNETClient.Services;

namespace SampleASPNETClient
{
    public partial class FormMahasiswa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
      
        public IEnumerable<Mahasiswa> gvMahasiswa_GetData()
        {
            MahasiswaServices mhsServices = new MahasiswaServices();
            return mhsServices.GetAll();
        }
    }
}