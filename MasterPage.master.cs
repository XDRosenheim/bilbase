using System;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] != null && Session["UserID"].ToString() == "1")
        {
            // Show links
            AdminLink.Visible = true;
            LogoutHyper.Visible = true;
            // Hide links
            LoginHyper.Visible = false;
        }
        else if (Session["UserID"] != null)
        {
            // Show links
            LogoutHyper.Visible = true;
            // Hide links
            AdminLink.Visible = false;
            LoginHyper.Visible = false;
        }
        else
        {
            // Show links
            LoginHyper.Visible = true;
            // Hide links
            LogoutHyper.Visible = false;
            AdminLink.Visible = false;
        }
    }
}