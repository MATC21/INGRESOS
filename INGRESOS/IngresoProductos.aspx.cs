using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegociosN;

namespace INGRESOS
{
    public partial class IngresoProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnguardarproducto_Click(object sender, EventArgs e)
        {
            try 
            {
                String respuesta = "";
                if (respuesta.Equals("!NO SE PUDO REALIZAR EL INGRESO"))
                {
                    
                }
                else
                {
                    //lblcorrecto.Visible = true;
                    //Limpiar();
                }
                respuesta = ProductosN.InsertarProductos(txtnombre.Text, txtdescripcion.Text, Convert.ToInt16(txtcantidad.Text),Convert.ToDecimal(txtprecio.Text),Convert.ToInt16(ddlcategoria.SelectedValue));
             
            } 
            catch (Exception ex) 
            { 
            
            }
        }
        public void Limpiar()
        {
            txtnombre.Text = String.Empty;
            txtdescripcion.Text = String.Empty;
            txtcantidad.Text = String.Empty;
            txtprecio.Text = String.Empty;
            ddlcategoria.Text = String.Empty;

        }
    }
}