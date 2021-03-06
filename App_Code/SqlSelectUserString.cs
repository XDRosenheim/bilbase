﻿using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class SqlSelectUserString
{
    public string DB_user_username;
    public string DB_user_password;
    public string DB_user_group;
    public string DB_user_mail;
    public string DB_user_tlf;
    public string DB_user_Id;
    public SqlDataReader SqlUserReader;
    public SqlDataReader SqlRowCount;

    
    public SqlSelectUserString(string commandString)
    {
        //string[] DB_user_username = new string[6];
        SqlString DatabaseString = new SqlString();

        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());

        SqlCommand DBCommand = new SqlCommand(commandString, DBStr);

        DBCommand.Connection = DBStr;
        DBStr.Open();
        //DBCommand.ExecuteReader();

        SqlUserReader = DBCommand.ExecuteReader();

        while (SqlUserReader.Read())
        {
            DB_user_username = SqlUserReader["username"].ToString();
            DB_user_password = SqlUserReader["password"].ToString();
            DB_user_group = SqlUserReader["usergroup"].ToString();
            DB_user_mail = SqlUserReader["mail"].ToString();
            DB_user_tlf = SqlUserReader["tlf"].ToString();
        }
    }
}