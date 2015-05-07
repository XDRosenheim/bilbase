using System.Data.SqlClient;

public class SqlString
{
    public string DatabaseString;
    public SqlString()
    {
        DatabaseString = @"Data Source=E310-NY-W08m;Initial Catalog=bilbase;Integrated Security=True";
    }
}