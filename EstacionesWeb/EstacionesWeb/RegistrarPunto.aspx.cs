
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
    public partial class RegistrarPunto : System.Web.UI.Page
    {
        PuntoDal punDal = new PuntoDal();
        RegionDal regDal = new RegionDal();
        TipoEstacionDal estaDal = new TipoEstacionDal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<REGION> region = new RegionDal().GetAll();
                regionBox.DataSource = region;
                regionBox.DataTextField = "NombreRegion";
                regionBox.DataBind();

                List<TIPOESTACION> TipEstac = new TipoEstacionDal().GetAll();
                puntotxt.DataSource = TipEstac;
                puntotxt.DataTextField = "Tipo";
                puntotxt.DataBind();
            }
        }

        protected void AgregarBtn_Click(object sender, EventArgs e)
        {
            PUNTO p = new PUNTO();

            p.Tipo = estaDal.GetAllID(puntotxt.Value);
            p.Direccion = direccionTxt.Value; 
            string reg = regDal.GetAllID(regionBox.Value);
            p.Region = reg;


            PuntoDal punDAL = new PuntoDal();
            punDAL.Add(p);

            exitoTxt.InnerText = "Punto Registrado Exitosamente";

            Limpiar();
        }

        private void Limpiar()
        {
            puntotxt.Value = "";
            direccionTxt.Value = "";
            regionBox.SelectedIndex = 0;
        }       
    }
}