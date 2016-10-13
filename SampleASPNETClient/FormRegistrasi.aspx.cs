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
    public partial class FormRegistrasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void frmRegistrasi_InsertItem()
        {
            PenggunaServices pgServices = new PenggunaServices();

            var newPengguna = new RegisterBindingModel();
            
            TryUpdateModel(newPengguna);
            if (ModelState.IsValid)
            {
                pgServices.Register(newPengguna);
                ltKeterangan.Text = "<div class='alert alert-success'>Registrasi Berhasil !</alert>";
            }
        }
    }
}