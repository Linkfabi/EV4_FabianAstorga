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
    public partial class ActualizarPunto : System.Web.UI.Page
    {
        PuntoDal punDal = new PuntoDal();
        RegionDal regDal = new RegionDal();
        TipoEstacionDal estaDal = new TipoEstacionDal();
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("LogVentas.aspx");
            }
            else
            {
                id = Int32.Parse(Request.QueryString["id"].ToString());
                nombrePaginaTxt.InnerText = "Actualizar Punto de Carga Numero " + id;
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

                    llenarDatos();
                }
            }
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            PUNTO p = new PUNTO();

            p.NumeroPuntoDeCarga = id;
            p.Tipo = estaDal.GetAllID(puntotxt.Value);
            p.Direccion = direccionTxt.Value;
            string reg = regDal.GetAllID(regionBox.Value);
            p.Region = reg;


            PuntoDal punDAL = new PuntoDal();
            punDAL.Actualizar(p);

            exitoTxt.InnerText = "Punto Actualizado Exitosamente";

            Limpiar();
        }

        private void Limpiar()
        {
            puntotxt.Value = "";
            direccionTxt.Value = "";
            regionBox.SelectedIndex = 0;
        }

        private void llenarDatos()
        {
            List<PUNTO> punt = new PuntoDal().GetALLporID(id);


            puntotxt.Value = estaDal.GetAllNombre(punt[0].Tipo.ToString());
            direccionTxt.Value = punt[0].Direccion.ToString();
            regionBox.Value = regDal.GetAllNombre(punt[0].Region.ToString());
        }

    }
}