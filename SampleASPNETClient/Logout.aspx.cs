using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleASPNETClient
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ProfilPengguna"]!=null)
            {
                Session["ProfilPengguna"] = null;
                Session.Clear();
                Response.Redirect("~/FormLogin");
            }
        }
    }
}