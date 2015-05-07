using System.Data.SqlClient;
using System.Web.UI.WebControls;

public class SqlString
{
    public SqlString(string commandString)
    {
        SqlConnection DBStr = new SqlConnection(@"Data Source=E310-NY-W08;Initial Catalog=bilbase;Integrated Security=True");
        SqlCommand DBCommand = new SqlCommand(commandString);
        SqlDataReader SqlUserReader;

        DBCommand.Connection = DBStr;
        DBStr.Open();
        SqlUserReader = DBCommand.ExecuteReader();
        DBStr.Close();
    }
}