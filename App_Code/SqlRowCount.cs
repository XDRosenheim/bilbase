using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SqlRowCount
/// </summary>
public class SqlRowCount
{
    public int Rows;

	public SqlRowCount(string TableToCountIn)
	{
        SqlString DatabaseString = new SqlString();
        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());
        SqlCommand DBCommand = new SqlCommand("SELECT COUNT(*) AS 'rowCount' FROM " + TableToCountIn, DBStr);
        DBStr.Open();
        SqlDataReader Reader = DBCommand.ExecuteReader();

        while (Reader.Read())
        {
            int.TryParse(Reader["rowCount"].ToString(), out Rows);
        }
	}
}