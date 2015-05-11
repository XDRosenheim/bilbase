using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class SqlSelectCarsString
{
    public string DB_cars_model;
    public string DB_cars_braendstoftype;
    public string DB_cars_kmperliter;
    public string DB_cars_pris;
    public string DB_cars_aargang;
    public string DB_cars_saeder;
    public string DB_cars_doere;
    public SqlDataReader SqlCarsReader;


    public SqlSelectCarsString(string commandString)
    {
        //string[] DB_user_username = new string[6];
        SqlString DatabaseString = new SqlString();

        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());

        SqlCommand DBCommand = new SqlCommand(commandString, DBStr);

        DBCommand.Connection = DBStr;
        DBStr.Open();
        //DBCommand.ExecuteReader();

        SqlCarsReader = DBCommand.ExecuteReader();

        while (SqlCarsReader.Read())
        {
            DB_cars_model = SqlCarsReader["model"].ToString();
            DB_cars_braendstoftype = SqlCarsReader["braendstofType"].ToString();
            DB_cars_kmperliter = SqlCarsReader["kmperliter"].ToString();
            DB_cars_pris = SqlCarsReader["pris"].ToString();
            DB_cars_aargang = SqlCarsReader["aargang"].ToString();
            DB_cars_saeder = SqlCarsReader["saeder"].ToString();
            DB_cars_doere = SqlCarsReader["doere"].ToString();
        }
    }
}