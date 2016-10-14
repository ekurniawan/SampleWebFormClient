using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SampleASPNETClient.Models;
using System.Web.Script.Serialization;

namespace SampleASPNETClient
{
    public partial class BerhasilLoginCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["ProfilPengguna"]==null)
            {
                Response.Redirect("~/FormLoginCookie");
            }
            else
            {
                var result = Request.Cookies["ProfilPengguna"].Value;
                ProfilPengguna profil = 
                    new JavaScriptSerializer().Deserialize<ProfilPengguna>(result);
                ltKeterangan.Text = "User anda : " + profil.userName + " " + profil.access_token;
            }
        }
    }
}