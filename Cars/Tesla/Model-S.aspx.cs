﻿using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class Model_S : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCarSelect CarSelect = new SqlCarSelect("Model S");

        car_model.Text = CarSelect.Car_Model;
        car_mærke.Text = CarSelect.Car_Brand;
        car_fueltype.Text = CarSelect.Car_Fueltype;
        car_distance.Text = CarSelect.Car_FuelUse;
        car_year.Text = CarSelect.Car_Year;
        car_seats.Text = CarSelect.Car_Seats;
        car_doors.Text = CarSelect.Car_Doors;

        if (CarSelect.Car_Fueltype == "El")
        {
            Label4.Text = "KM/Opladning";
        }

        LiteralControl LT = new LiteralControl();

        //SqlCommentSelectString Comments = new SqlCommentSelectString("SELECT * FROM comment_Tesla_Model_S ");

        for (int i = 0; i < INSERTLENGHTHERE; i++)
        {
            LT.Text = "<asp:Label class=\"Comments\" ID=\"comment\" runat=\"server\" Text=" + Comments.SqlCommentReader["comment"].ToString() + "></asp:Label><br>";
            comment.Controls.Add(LT);
        }
    }
}