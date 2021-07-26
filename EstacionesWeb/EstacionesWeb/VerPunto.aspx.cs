
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
    public partial class VerPunto : System.Web.UI.Page
    {
        PuntoDal punDAL = new PuntoDal();
        TipoEstacionDal tipesDal = new TipoEstacionDal();

        private void CargarTabla(List<PUNTO> puntos)
        {
            PuntoGrid.DataSource = puntos;
            PuntoGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(punDAL.GetAll());
            }

        }

        protected void puntoGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string id = e.CommandArgument.ToString();
                punDAL.Remove(Int32.Parse(id));
                CargarTabla(punDAL.GetAll());
            }

            if (e.CommandName == "actualizar")
            {
                string id = e.CommandArgument.ToString();
                Response.Redirect("ActualizarPunto.aspx?id=" + id);
            }

        }

        protected void select_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string tiposelect = nivelDdl.SelectedValue;

            if(tiposelect == "1")
            {
                CargarTabla(punDAL.GetAll());
            }
            else
            {
                string var = tipesDal.GetAllID(tiposelect);
                List<PUNTO> filtrada = punDAL.GetALL(var);
                CargarTabla(filtrada);
            }
            
        }
    }
}