using System.Configuration;
using System.Data.SqlClient;

public class DatabaseConnection
{
    private static string connectionString = ConfigurationManager.ConnectionStrings["TeatrosDBConnection"].ConnectionString;



    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);

    }
}