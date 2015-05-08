using System.Data.SqlClient;

public class SqlModifyCarsString
{
	public SqlModifyCarsString(string commandString)
	{
        SqlString DatabaseString = new SqlString();

        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());
        SqlCommand DBCommand = new SqlCommand(commandString);
        SqlDataReader SqlCarsReader;

        DBCommand.Connection = DBStr;
        DBStr.Open();
        SqlCarsReader = DBCommand.ExecuteReader();

        DBStr.Close();
	}
}