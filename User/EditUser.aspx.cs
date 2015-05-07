using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class EditUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] != null && Session["UserId"].ToString() == "1") { }
        else { Response.Redirect("/"); }

        SqlString DatabaseString = new SqlString();
        SqlConnection DBStr = new SqlConnection(DatabaseString.DatabaseString.ToString());

        SqlCommand DBSelectAll = new SqlCommand("SELECT * FROM users", DBStr);
        DBSelectAll.Connection = DBStr;
        DBStr.Open();
        SqlDataReader Reader = DBSelectAll.ExecuteReader();

        int i = 0;
        while (Reader.Read())
        {
            string DB_select_username = Reader["username"].ToString();
            GetUser_DDL.Items.Insert(i, new ListItem(DB_select_username, DB_select_username));
            i++;
        }
        DBStr.Close();
    }
    protected void EditUser_Btn_Click(object sender, EventArgs e)
    {
        if (Username_Field.Text != "" || Password_Field.Text != "" || Mail_Field.Text != "" || Tlf_Field.Text != "" || Rolle_DDL.Text != "")
        {

            SqlModifyUserString EditUsers = new SqlModifyUserString("Update users set username='" + Username_Field.Text + "', password='" + Password_Field.Text + "', mail='" + Mail_Field.Text + "', tlf='" + Tlf_Field.Text + "', usergroup=" + Rolle_DDL.Text + " where username='" + GetUser_DDL.Text + "'");

            StatusText_Label.Text = "Du har redigeret informationer for brugeren " + GetUser_DDL.Text;
        }
        else
        {
            StatusText_Label.Text = "Du har ikke indtastet en værdi i alle felterne.";
        }
    }
    protected void GetValues_Btn_Click(object sender, EventArgs e)
    {
        SqlSelectUserString GetUsers = new SqlSelectUserString("select * from users where username='" + GetUser_DDL.Text + "' ");

        Username_Field.Text = GetUsers.DB_user_username;
        Password_Field.Text = GetUsers.DB_user_password;
        Mail_Field.Text = GetUsers.DB_user_mail;
        Tlf_Field.Text = GetUsers.DB_user_tlf;
        Rolle_DDL.Text = GetUsers.DB_user_group;
    }
    protected void EditUser_del_Click(object sender, EventArgs e)
    {
        if (Username_Field.Text == "")
        {
            Label1.Text = "Ingen bruger er valgt, hent bruger data og prøv igen.";
            Label1.Visible = true;
        }
        else
        {
            btn_NOPE.Visible = true;
            btn_sure.Visible = true;
            Label1.Visible = true;
        }
    }
    protected void btn_sure_Click(object sender, EventArgs e)
    {
        SqlModifyUserString DelUser = new SqlModifyUserString("DELETE FROM users WHERE username='" + Username_Field.Text + "'");
        Response.Redirect("/User/EditUser.aspx");
    }
    protected void btn_NOPE_Click(object sender, EventArgs e)
    {
        Response.Redirect("/User/EditUser.aspx");
    }
}