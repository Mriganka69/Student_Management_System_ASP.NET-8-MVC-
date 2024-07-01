using System;
using System.Data;
using System.Web.UI;

namespace StudentMS.Views
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == 0)
            {
                ErrMsg.InnerText = "Select a Role !!!";
            }
            else if (RoleCb.SelectedIndex == 1)
            {
                if (EmailTb.Value == "Admin@gmail.com" && PasswordTb.Value == "Admin")
                {
                    string role = "Admin";
                    Session["uid"] = 1;
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "Admin/Students.aspx";

                    // Show alert and redirect using JavaScript
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert",
                        $"showAlertAndRedirect('{r_url}');", true);
                }
                else
                {
                    ErrMsg.InnerText = "NOT ADMIN !!!";
                }
            }
            else if (RoleCb.SelectedIndex == 2)
            {
                string query = "select * from StudentTb where StudentEmail = '{0}' and Password = '{1}' ";
                query = string.Format(query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetDatas(query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Student";
                }
                else
                {
                    string role = "Student";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "Admin/Students.aspx";

                    // Show alert and redirect using JavaScript
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert",
                        $"showAlertAndRedirect('{r_url}');", true);
                }
            }
            else if (RoleCb.SelectedIndex == 3)
            {
                string query = "select * from TeachersTb where TeacherEmail = '{0}' and Password = '{1}' ";
                query = string.Format(query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetDatas(query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Teacher";
                }
                else
                {
                    string role = "Teacher";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "Admin/Teachers.aspx";

                    // Show alert and redirect using JavaScript
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert",
                        $"showAlertAndRedirect('{r_url}');", true);
                }
            }
        }
    }
}
