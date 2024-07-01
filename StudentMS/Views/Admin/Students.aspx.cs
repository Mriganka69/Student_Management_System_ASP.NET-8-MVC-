using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentMS.Views.Admin
{   
    public partial class Students : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowStudents();
        }

        private void ShowStudents()
        {
            string Query = "Select * from StudentTb WHERE StudentId IS NOT NULL";

            StudentsGV.DataSource = Con.GetDatas(Query);
            StudentsGV.DataBind();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SName = StudentNameTb.Value;
                string SPhone = StudentPhoneTb.Value;
                string SAdd = StudentAddressTb.Value;
                string SEmail = StudentEmailTb.Value;
                string SGender = StudentGenderTb.SelectedItem.ToString();
                string SPassword = PasswordTb.Value;
                string Query = "insert into StudentTb values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = string.Format(Query, SName, SPhone, SAdd, SEmail, SGender, SPassword);
                Con.SetDatas(Query);
                ShowStudents();
                ErrMsg.InnerText = "Student Added!!!";
                StudentNameTb.Value = "";
                StudentPhoneTb.Value = "";
                StudentAddressTb.Value = "";
                StudentEmailTb.Value = "";
                StudentGenderTb.SelectedIndex = -1;
                PasswordTb.Value = "";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        int Key = 0;    
        protected void StudentsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentNameTb.Value = StudentsGV.SelectedRow.Cells[2].Text;
            StudentPhoneTb.Value = StudentsGV.SelectedRow.Cells[3].Text;
            StudentAddressTb.Value = StudentsGV.SelectedRow.Cells[4].Text;
            StudentEmailTb.Value = StudentsGV.SelectedRow.Cells[5].Text;
            StudentGenderTb.SelectedItem.Value = StudentsGV.SelectedRow.Cells[6].Text;
            PasswordTb.Value = StudentsGV.SelectedRow.Cells[7].Text;
            if (StudentNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Select a Student";
                }
                else
                {
                    string Query = "DELETE FROM StudentTb WHERE StudentId = {0} ";
                    Query = string.Format(Query, StudentsGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowStudents();
                    ErrMsg.InnerText = "Student Deleted !!!";
                    Key = 0;
                    StudentNameTb.Value = "";
                    StudentPhoneTb.Value = "";
                    StudentAddressTb.Value = "";
                    StudentEmailTb.Value = "";
                    StudentGenderTb.SelectedIndex = -1;
                    PasswordTb.Value = "";
                }

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string SName = StudentNameTb.Value;
                string SPhone = StudentPhoneTb.Value;
                string SAdd = StudentAddressTb.Value;
                string SEmail = StudentEmailTb.Value;
                string SGender = StudentGenderTb.SelectedItem.ToString();
                string SPassword = PasswordTb.Value;
                string Query = "update StudentTb set StudentName = '{0}' , StudentPhone = '{1}' , StudentAddress = '{2}', StudentEmail = '{3}' , StudentGender = '{4}' , Password = '{5}' where StudentId = {6} ";
                Query = string.Format(Query, SName, SPhone, SAdd, SEmail, SGender, SPassword, StudentsGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ShowStudents();
                ErrMsg.InnerText = "Student Updated !!!";
                StudentNameTb.Value = "";
                StudentPhoneTb.Value = "";
                StudentAddressTb.Value = "";
                StudentEmailTb.Value = "";
                StudentGenderTb.SelectedIndex = -1;
                PasswordTb.Value = "";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}