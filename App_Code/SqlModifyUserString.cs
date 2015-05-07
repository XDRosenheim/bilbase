using System.Data.SqlClient;

public class SqlModifyUserString
{
	public SqlModifyUserString(string commandString)
	{
        SqlConnection DBStr = new SqlConnection(@"Data Source=E310-NY-W04\ROSENHEIM;Initial Catalog=bilbase;Integrated Security=True");
        SqlCommand DBCommand = new SqlCommand(commandString);
        SqlDataReader SqlUserReader;

        DBCommand.Connection = DBStr;
        DBStr.Open();
        SqlUserReader = DBCommand.ExecuteReader();


        DBStr.Close();
	}
}