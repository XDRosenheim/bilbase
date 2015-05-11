using System;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SqlCommentSelectString
/// </summary>
public class SqlCommentSelectString
{
    public string DB_comment, DB_commenter, DB_rateing;
    public SqlDataReader SqlCommentReader;

	public SqlCommentSelectString(string commandString)
	{
        SqlString DatabaseString = new SqlString();

        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());

        SqlCommand DBCommand = new SqlCommand(commandString, DBStr);

        DBCommand.Connection = DBStr;
        DBStr.Open();
        //DBCommand.ExecuteReader();

        SqlCommentReader = DBCommand.ExecuteReader();

        while (SqlCommentReader.Read())
        {
            DB_comment = SqlCommentReader["comment"].ToString();
            DB_commenter = SqlCommentReader["Commenter"].ToString();
            DB_rateing = SqlCommentReader["rate"].ToString();
        }
	}
}