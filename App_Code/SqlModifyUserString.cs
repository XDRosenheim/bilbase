using System.Data.SqlClient;

public class SqlModifyUserString
{
	public SqlModifyUserString(string commandString)
	{
        SqlString DatabaseString = new SqlString();

        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());
        SqlCommand DBCommand = new SqlCommand(commandString);
        SqlDataReader SqlUserReader;

        DBCommand.Connection = DBStr;
        DBStr.Open();
        SqlUserReader = DBCommand.ExecuteReader();
        DBStr.Close();
	}
}