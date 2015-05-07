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
        if (Session["UserId"] != null && Session["UserId"].ToString() == "1")
        {

        }
        else
        {
            Response.Redirect("/");
        }

        SqlSelectUserString SelectUsers = new SqlSelectUserString("SELECT * FROM users");

        SqlConnection DBStr = new SqlConnection(@"Data Source=E310-NY-W08;Initial Catalog=bilbase;Integrated Security=True");

        SqlCommand DBSelectAll = new SqlCommand("SELECT * FROM users", DBStr);
        DBSelectAll.Connection = DBStr;
        SqlDataReader Reader;
        DBStr.Open();
        Reader = DBSelectAll.ExecuteReader();

        int i = 0;
        while(Reader.Read())
        {
        string DB_select_username = Reader["username"].ToString();
        GetUser_DDL.Items.Insert(i, new ListItem(DB_select_username, DB_select_username));
        i++;
        }
        DBStr.Close();
    }
    protected void EditUser_Btn_Click(object sender, EventArgs e)
    {
        if (Username_Field.Text != "" || Password_Field.Text != "" || Mail_Field.Text != "" || Tlf_Field.Text != "" || Rolle_DDL.Text != "" )
        {

            SqlString EditUsers = new SqlString("Update users set username='" + Username_Field.Text + "', password='" + Password_Field.Text + "', mail='" + Mail_Field.Text + "', tlf='" + Tlf_Field.Text + "', usergroup=" + Rolle_DDL.Text + " where username='" + GetUser_DDL.Text + "'");

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
}