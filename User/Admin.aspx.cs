using System;

public partial class AdminClass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Check if admin is logged in.
        if (Session["UserId"] != null && Session["UserId"].ToString() == "1")
        {

        }
        else
        {
            Response.Redirect("/");
        }
    }
}