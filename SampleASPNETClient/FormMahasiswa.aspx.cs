using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SampleASPNETClient.Models;
using SampleASPNETClient.Services;
using System.Web.ModelBinding;

namespace SampleASPNETClient
{
    public partial class FormMahasiswa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ProfilPengguna"]==null)
            {
                Response.Redirect("~/FormLogin");
            }
        }
      
        public IEnumerable<Mahasiswa> gvMahasiswa_GetData([Control("txtNama")] string nama)
        {
            var profil = (ProfilPengguna)Session["ProfilPengguna"];
            MahasiswaServices mhsServices = new MahasiswaServices();
            if (nama!=null)
            {
                return mhsServices.GetByNama(nama,profil.access_token);
            }
            else
            {
                return mhsServices.GetAll(profil.access_token);
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvMahasiswa_UpdateItem(string Nim)
        {
            var profil = (ProfilPengguna)Session["ProfilPengguna"];

            MahasiswaServices mhsServices = new MahasiswaServices();

            Mahasiswa item = mhsServices.GetById(Nim,profil.access_token);
            if (item == null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", Nim));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                mhsServices.Put(Nim, item, profil.access_token);
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvMahasiswa_DeleteItem(string Nim)
        {
            var profil = (ProfilPengguna)Session["ProfilPengguna"];

            MahasiswaServices mhsServices = new MahasiswaServices();
            Mahasiswa item = mhsServices.GetById(Nim,profil.access_token);

            if(item==null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", Nim));
                return;
            }

            if(ModelState.IsValid)
            {
                mhsServices.Delete(Nim,profil.access_token);
            }
        }
    }
}