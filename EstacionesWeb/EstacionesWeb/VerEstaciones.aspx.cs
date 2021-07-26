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
    public partial class VerEstaciones : System.Web.UI.Page
    {
        EstacionDal estaDAL = new EstacionDal();

        private void CargarTabla(List<ESTACION> estaciones)
        {
            EstacionGrid.DataSource = estaciones;
            EstacionGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(estaDAL.GetAll());
            }
            
        }

        protected void estacionGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string id =e.CommandArgument.ToString();
                estaDAL.Remove(Int32.Parse(id));
                CargarTabla(estaDAL.GetAll());
            }
        }
    }
}