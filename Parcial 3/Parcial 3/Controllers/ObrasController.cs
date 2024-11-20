using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class ObrasPage : System.Web.UI.Page
{
    private string _connectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        _connectionString = ConfigurationManager.ConnectionStrings["TeatroBDConnection"].ConnectionString;

        if (!IsPostBack)
        {
            BindObras();
        }
    }

    private void BindObras()
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Obras";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            ObrasGridView.DataSource = reader;
            ObrasGridView.DataBind();
        }
    }

    protected void ObrasGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ViewDetails")
        {
            int obraId = Convert.ToInt32(e.CommandArgument);
            Response.Redirect($"ObrasDetails.aspx?id={obraId}");
        }
    }
}