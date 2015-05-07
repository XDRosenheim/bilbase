using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Class to count rows in the given table.
/// </summary>
public class SqlRowCount
{
    public int RowCount = 0;
	public SqlRowCount(string tableToCountIn)
	{
        SqlString DatabaseString = new SqlString();

        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());
        SqlCommand DBCommand = new SqlCommand("SELECT COUNT(*) FROM " + tableToCountIn);
        SqlDataReader SqlReader;

        DBCommand.Connection = DBStr;
        DBStr.Open();
        SqlReader = DBCommand.ExecuteReader();

        while (SqlReader.Read())
        {
            RowCount++;
        }

        DBStr.Close();
	}
}