using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Libreria2
{
    public partial class VerDatos : System.Web.UI.Page
    {
        ServicioLinqDataContext data = new ServicioLinqDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getData();
            }

        }

        public void getData()
        {
            var empresas = from u in data.GetTable<empresa>() select u;
            gridViewLinQ.DataSource = empresas.ToList();
            gridViewLinQ.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var identificacion_ = txtIdentificacion.Text;
            var empresas = from empresa in data.GetTable<empresa>() where empresa.identificacion == identificacion_  select empresa;
            gridViewLinQ.DataSource = empresas.ToList();
            gridViewLinQ.DataBind();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            getData();
            txtIdentificacion.Text = "";
        }
    }
}