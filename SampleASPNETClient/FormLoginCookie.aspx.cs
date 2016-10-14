using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SampleASPNETClient.Services;
using SampleASPNETClient.Models;
using System.Web.Script.Serialization;

namespace SampleASPNETClient
{
    public partial class FormLoginCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PenggunaServices penggunaServices = new PenggunaServices();

            var result = penggunaServices.GetLogin(Username.Text, Password.Text);

            var strProfil = new JavaScriptSerializer().Serialize(result);
            if (result.error_description==null)
            {
                HttpCookie cookiePengguna = new HttpCookie("ProfilPengguna")
                {
                    Value = strProfil,
                    Expires = DateTime.Now.AddHours(1)
                    //Domain = ".uajy.ac.id"
                };
                if (Request.Cookies["ProfilPengguna"]==null)
                {
                    Response.Cookies.Add(cookiePengguna);
                }
                else
                {
                    Response.SetCookie(cookiePengguna);
                }
                Response.Redirect("~/BerhasilLoginCookie");
            }
            else
            {
                ltKeterangan.Text = "<div class='alert alert-danger'>Login Gagal !</div>";
            }
        }
    }
}