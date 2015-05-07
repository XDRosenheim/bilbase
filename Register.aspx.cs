using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btn_regit_Click(object sender, EventArgs e)
    {
        if (EnterUsername_Field.Text != "" && EnterPassword_Field.Text != "" && ReEnterPassword_Field.Text != "")
        {
            if (EnterPassword_Field.Text == ReEnterPassword_Field.Text)
            {
                SqlModifyUserString Insert = new SqlModifyUserString("INSERT INTO users VALUES('" + EnterUsername_Field.Text.ToLower() + "','" 
                    + EnterPassword_Field.Text + "',2,'" + EnterMail_Field.Text.ToLower() + "','" + EnterTlf_Field.Text + "')");

                Status_label.Visible = true;
                Status_label.Text = EnterUsername_Field.Text + ", er oprettet.";

                EnterMail_Field.Text = "";
                EnterPassword_Field.Text = "";
                EnterTlf_Field.Text = "";
                EnterUsername_Field.Text = "";
                ReEnterPassword_Field.Text = "";
            }
            else
            {
                Status_label.Visible = true;
                Status_label.Text = "Password matcher ikke.";
            }
        }
        else
        {
            Status_label.Visible = true;
            Status_label.Text = "Enter something......";
        }
    }
}