using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms.Label;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usergroup"] != null && Session["usergroup"].ToString() == "Administrator")
        {
            AdminLink.Visible = true;
        }

        Label newLabel = new Label();

        

        SqlRowCount RowCounter = new SqlRowCount("cars");

        for (int i = 0; i < RowCounter.RowCount; i++)
        {
            // Insert new label.
        }
    }
}
