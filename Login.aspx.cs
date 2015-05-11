using System;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Login_Btn_Click(object sender, EventArgs e)
    {
        if (Username_Field.Text != "" && Password_Field.Text != "")
        {
            SqlSelectUserString SqlCmd = new SqlSelectUserString("Select * from users where username = '" + Username_Field.Text.ToLower() + "' AND password = '" + Password_Field.Text + "'");
            Session["UserId"] = SqlCmd.DB_user_group.ToString();

            if (Username_Field.Text.ToLower() == SqlCmd.DB_user_username && Password_Field.Text == SqlCmd.DB_user_password && Session["UserId"].ToString() != null)
            {
                switch (Session["UserId"].ToString())
                {
                    case "1":
                        Response.Redirect("/User/Admin.aspx");
                        break;
                    case "2":
                        Response.Redirect("/Default.aspx");
                        break;
                    default:
                        Response.Redirect("/");
                        break;
                }
            }
            else
            {
                Response.Write("Brugeren findes ikke i databasen. Kontakt venligst Administratoren.");
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}