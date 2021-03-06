﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class EditCars : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] != null && Session["UserId"].ToString() == "1") { }
        else { Response.Redirect("/"); }

        SqlString DatabaseString = new SqlString();
        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());

        SqlCommand DBSelectAll = new SqlCommand("SELECT * FROM cars INNER JOIN maerke ON maerke.maerkeID = cars.maerke INNER JOIN braendstof ON braendstof.ID = cars.braendstofType", DBStr);
        DBSelectAll.Connection = DBStr;
        DBStr.Open();
        SqlDataReader Reader = DBSelectAll.ExecuteReader();

        int i = 0;
        while (Reader.Read())
        {
            string DB_select_carmodel = Reader["model"].ToString();
            GetCarModel_DDL.Items.Insert(i, new ListItem(DB_select_carmodel, DB_select_carmodel));
            i++;
        }
        DBStr.Close();
    }

    protected void GetValues_Btn_Click(object sender, EventArgs e)
    {
        SqlSelectCarsString GetCars = new SqlSelectCarsString("SELECT * FROM cars INNER JOIN maerke ON maerke.maerkeID = cars.maerke INNER JOIN braendstof ON braendstof.ID = cars.braendstofType WHERE model='" + GetCarModel_DDL.Text + "' ");

        Model_Field.Text = GetCars.DB_cars_model;
        BraendstofType_DDL.Text = GetCars.DB_cars_braendstoftype;
        KmPerLiter_Field.Text = GetCars.DB_cars_kmperliter;
        Pris_Field.Text = GetCars.DB_cars_pris;
        Aargang_Field.Text = GetCars.DB_cars_aargang;
        Saeder_Field.Text = GetCars.DB_cars_saeder;
        Doere_Field.Text = GetCars.DB_cars_doere;

        if (GetCars.DB_cars_braendstoftype == "El")
        { 
            KmPerLiter_Label.Text = "KM/Opladning:"; 
        }
        else 
        { 
            KmPerLiter_Label.Text = "KM per liter:"; 
        }
    }

    protected void EditUser_Btn_Click(object sender, EventArgs e) // Copy pasta
    {
        if (Model_Field.Text != "" || BraendstofType_DDL.Text != "" || KmPerLiter_Field.Text != "" || Pris_Field.Text != "" || Aargang_Field.Text != "" || Saeder_Field.Text != "" || Doere_Field.Text != "")
        {
            int braendstofint = 1;
            switch (BraendstofType_DDL.SelectedItem.Text)
            {
                case "Benzin":
                    braendstofint = 1;
                    break;
                case "Diesel":
                    braendstofint = 2;
                    break;
                case "El":
                    braendstofint = 3;
                    break;
                case "Hybrid":
                    braendstofint = 4;
                    break;
            }

            SqlRunCommandString EditUsers = new SqlRunCommandString("Update cars set model='" + Model_Field.Text + "', braendstoftype='" + braendstofint + "', kmperliter=" + KmPerLiter_Field.Text.Replace(",",".") + ", pris='" + Pris_Field.Text + "', aargang='" + Aargang_Field.Text + "', saeder='" + Saeder_Field.Text + "', doere='" + Doere_Field.Text + "' where model='" + GetCarModel_DDL.Text + "'");

            StatusText_Label.Text = "Du har redigeret informationer for bilen " + GetCarModel_DDL.Text;
        }
        else
        {
            StatusText_Label.Text = "Du har ikke indtastet en værdi i alle felterne.";
        }
    }
}