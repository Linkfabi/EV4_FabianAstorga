using EstacionesBD;
using EstacionesBD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstacionesWeb
{
    public partial class RegistrarEstaciones : System.Web.UI.Page
    {
        RegionDal regDal = new RegionDal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<REGION> region = new RegionDal().GetAll();
                regionBox.DataSource = region;
                regionBox.DataTextField = "NombreRegion";
                regionBox.DataBind();
            }
        }

        protected void AgregarBtn_Click(object sender, EventArgs e)
        {
            ESTACION es = new ESTACION();
            
            es.Fecha = fechaTxt.Value;
            es.Direccion = direccionTxt.Value;
            string reg = regDal.GetAllID(regionBox.Value);

            es.Region = reg;

            EstacionDal esDAL = new EstacionDal();

            esDAL.Add(es);

            exitoTxt.InnerText = "Estacion Registrada Exitosamente";

            Limpiar();
        }

        private void Limpiar()
        {
            fechaTxt.Value = "";
            direccionTxt.Value = "";
            regionBox.SelectedIndex = 0;
        }

    }
}