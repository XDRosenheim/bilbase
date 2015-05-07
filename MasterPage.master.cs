using System;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] != null && Session["UserID"].ToString() == "1")
        {
            AdminLink.Visible = true;
        }
    }
}