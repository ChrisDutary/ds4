using System;
using System.Text;

namespace Laboratorio202
{
    public partial class MatrizDiagonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                litMatriz.Text = "";
                lblError.Text = "";
            }
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            litMatriz.Text = "";

            if (string.IsNullOrEmpty(txtTamano.Text))
            {
                lblError.Text = "Por favor, ingrese el tamaño de la matriz.";
                return;
            }

            if (int.TryParse(txtTamano.Text, out int n))
            {
                if (n >= 2 && n <= 10)  // Limitamos el tamaño entre 2 y 10 para mejor visualización
                {
                    StringBuilder matrizHtml = new StringBuilder();
                    matrizHtml.Append("<table class='matriz'>");

                    for (int i = 0; i < n; i++)
                    {
                        matrizHtml.Append("<tr>");
                        for (int j = 0; j < n; j++)
                        {
                            // La diagonal inversa es cuando i + j = n - 1
                            if (i + j == n - 1)
                            {
                                matrizHtml.Append("<td class='diagonal'>1</td>");
                            }
                            else
                            {
                                matrizHtml.Append("<td>0</td>");
                            }
                        }
                        matrizHtml.Append("</tr>");
                    }

                    matrizHtml.Append("</table>");
                    litMatriz.Text = matrizHtml.ToString();
                }
                else
                {
                    lblError.Text = "Por favor, ingrese un número entre 2 y 10.";
                }
            }
            else
            {
                lblError.Text = "Por favor, ingrese un número válido.";
            }
        }
    }
}