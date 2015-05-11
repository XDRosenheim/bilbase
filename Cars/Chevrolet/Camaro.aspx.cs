﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Camaro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCarSelect CarSelect = new SqlCarSelect("Camaro"); //TODO

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
        SqlRowCount rowCounter = new SqlRowCount("comment_Chevrolet_Camaro");
        if (rowCounter.Rows == 0) { }
        else
        {
            for (int i = 1; i <= rowCounter.Rows; i++)
            {
                SqlCommentSelectString Comments = new SqlCommentSelectString("SELECT * FROM comment_Chevrolet_Camaro WHERE ID=" + i);
                LT.Text = "<div class=\"Comments\" ><p>" + Comments.DB_comment + "</p><br />";
                comment.Controls.Add(LT);
            }
        }
    }
}