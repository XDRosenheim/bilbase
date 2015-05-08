using System;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] != null && Session["UserID"].ToString() == "1")
        {
            AdminLink.Visible = true;
            LoginHyper.Visible = false;
            LogoutHyper.Visible = true;
        }
        else if (Session["UserID"] != null)
        {
            LoginHyper.Visible = false;
            LogoutHyper.Visible = true;
        }
        LogoutHyper.Visible = false;
    }
}