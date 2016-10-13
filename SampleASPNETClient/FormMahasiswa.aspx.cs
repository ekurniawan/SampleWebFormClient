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

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvMahasiswa_UpdateItem(string Nim)
        {
            MahasiswaServices mhsServices = new MahasiswaServices();

            Mahasiswa item = mhsServices.GetById(Nim);
            if (item == null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", Nim));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                mhsServices.Put(Nim, item);
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvMahasiswa_DeleteItem(string Nim)
        {
            MahasiswaServices mhsServices = new MahasiswaServices();
            Mahasiswa item = mhsServices.GetById(Nim);

            if(item==null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", Nim));
                return;
            }

            if(ModelState.IsValid)
            {
                mhsServices.Delete(Nim);
            }
        }
    }
}