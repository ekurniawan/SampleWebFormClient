using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SampleASPNETClient.Services;
using SampleASPNETClient.Models;

namespace SampleASPNETClient
{
    public partial class FormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PenggunaServices penggunaServices = new PenggunaServices();

            var result = penggunaServices.GetLogin(Username.Text, Password.Text);

            if(result.error_description!=null)
            {
                ltError.Text = "<div class='alert alert-danger'>" + 
                    result.error_description + "</div>";
            }
            else
            {
                //menyimpan informasi profil pengguna kedalam session
                Session["ProfilPengguna"] = result;
                Response.Redirect("~/BerhasilLogin");
            }
        }
    }
}