using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SqlCommentInsertString
/// </summary>
public class SqlCommentInsertString
{
	public SqlCommentInsertString(string commandString)
	{
        SqlString DatabaseString = new SqlString();
        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());
        SqlCommand DBCommand = new SqlCommand(commandString, DBStr);
        //DBCommand.Connection = DBStr;
        DBStr.Open();
	}
}