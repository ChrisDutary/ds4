using System;
using System.Text;

namespace Laboratorio201
{
    public partial class TablaMultiplicar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblResultado.Text = "";
                lblError.Text = "";
            }
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblResultado.Text = "";

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                lblError.Text = "Por favor, ingrese un número.";
                return;
            }

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (numero <= 25) 
                {
                    StringBuilder tabla = new StringBuilder();
                    tabla.Append("<table border='1' style='border-collapse: collapse; margin-top: 10px;'>");
                    tabla.Append("<tr style='background-color: #f2f2f2;'>");
                    tabla.Append("<th style='padding: 8px; text-align: center;'>Operación</th>");
                    tabla.Append("<th style='padding: 8px; text-align: center;'>Resultado</th></tr>");

              
                    for (int i = 1; i <= 12; i++)
                    {

                        tabla.Append("<tr>");
                        tabla.Append($"<td style='padding: 8px; text-align: center;'>{numero} × {i}</td>");
                        tabla.Append($"<td style='padding: 8px; text-align: center;'>{numero * i}</td>");
                        tabla.Append("</tr>");
                    }

                    tabla.Append("</table>");
                    lblResultado.Text = tabla.ToString();
                }
                else
                {
                    lblError.Text = "Por favor, ingrese un número menor o igual a 25.";
                }
            }
            else
            {
                lblError.Text = "Por favor, ingrese un número válido.";
            }
        }
    }
}