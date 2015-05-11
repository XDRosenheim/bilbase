using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Civic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] != null)
        {
            TextBox.Visible = true;
            commentBtn.Visible = true;
        }
        else
        {
            TextBox.Visible = false;
            commentBtn.Visible = false;
        }

        SqlCarSelect CarSelect = new SqlCarSelect("Civic");

        car_model.Text = CarSelect.Car_Model;
        car_mærke.Text = CarSelect.Car_Brand;
        car_fueltype.Text = CarSelect.Car_Fueltype;
        car_distance.Text = CarSelect.Car_FuelUse;
        car_year.Text = CarSelect.Car_Year;
        car_seats.Text = CarSelect.Car_Seats;
        car_doors.Text = CarSelect.Car_Doors;

        LiteralControl LT = new LiteralControl();
        SqlRowCount rowCounter = new SqlRowCount("comment_Honda_Civic");
        if (rowCounter.Rows == 0) { }
        else
        {
            for (int i = 1; i <= rowCounter.Rows; i++)
            {
                SqlCommentSelectString Comments = new SqlCommentSelectString("SELECT * FROM comment_Honda_Civic WHERE ID=" + i);
                LT.Text = "<div class=\"Comments\" ><p>" + Comments.DB_comment + "</p></div><br />";
                comment.Controls.Add(LT);
            }
        }
    }

    protected void commentBtn_Click(object sender, EventArgs e)
    {
        if (TextBox.Text != "")
        {
            // TODO
            // Insert comment
            something sqlinsert = new something("INSERT INTO comment_Honda_Civic VALUES ('" + TextBox.Text + "')");
        }
        else
        {
            // TODO
            // Do nothing.
        }
    }
}