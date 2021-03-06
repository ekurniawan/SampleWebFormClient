﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SampleASPNETClient.Models;
using SampleASPNETClient.Services;

namespace SampleASPNETClient
{
    public partial class FormAddMahasiswa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ProfilPengguna"]==null)
            {
                Response.Redirect("~/FormLogin");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var profil = (ProfilPengguna)Session["ProfilPengguna"];

            Mahasiswa newMhs = new Mahasiswa
            {
                Nim = txtNim.Text,
                Nama = txtNama.Text,
                Email = txtEmail.Text,
                IPK = Convert.ToDouble(txtIPK.Text)
            };

            MahasiswaServices mhsServices = new MahasiswaServices();
            try
            {
                mhsServices.Post(newMhs,profil.access_token);
                Response.Redirect("~/FormMahasiswa");
            }
            catch (Exception ex)
            {
                ltKet.Text = "<div class='alert alert-warning'>" + ex.Message + "</div>";
            }
        }
    }
}