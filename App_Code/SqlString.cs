using System.Data.SqlClient;

public class SqlString
{
    public string DatabaseString;
    public SqlString()
    {
        DatabaseString = @"Data Source=gl8xk92yzj.database.windows.net,1433;Initial Catalog=BilBase;Persist Security Info=True;User ID=H3;Password=BilBase3";
    }
}