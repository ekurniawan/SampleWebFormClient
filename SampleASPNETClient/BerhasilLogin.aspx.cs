using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SampleASPNETClient.Models;

namespace SampleASPNETClient
{
    public partial class BerhasilLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ProfilPengguna"]==null)
            {
                Response.Redirect("~/FormLogin");
            }
            else
            {
                ProfilPengguna profil = (ProfilPengguna)Session["ProfilPengguna"];
                ltKeterangan.Text = "Token " + profil.access_token;
            }
        }
    }
}