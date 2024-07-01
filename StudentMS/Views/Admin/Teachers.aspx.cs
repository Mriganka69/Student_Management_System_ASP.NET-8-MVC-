using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentMS.Views.Admin
{
    public partial class Teachers : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowTeachers();
        }
        // Overriden Method
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowTeachers()
        {
            string Query = "Select * from TeachersTb WHERE TeacherId IS NOT NULL";

            TeachersGV.DataSource = Con.GetDatas(Query);
            TeachersGV.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string RName = TeacherNameTb.Value;
                string RPhone = TeacherPhoneTb.Value;
                string RAdd = TeacherAddressTb.Value;
                string REmail = TeacherEmailTb.Value;
                string RGender = TeacherGenderTb.Value;
                string Password = PasswordTb.Value;
                string Query = "insert into TeachersTb values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = string.Format(Query, RName, RPhone, RAdd, REmail, RGender, Password);
                Con.SetDatas(Query);
                ShowTeachers();
                ErrMsg.InnerText = "Teacher Added!!!";
                TeacherNameTb.Value = "";
                TeacherPhoneTb.Value = "";
                TeacherAddressTb.Value = "";
                TeacherEmailTb.Value = "";
                TeacherGenderTb.Value = "";
                PasswordTb.Value = "";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        int Key = 0;
        protected void TeachersGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeacherNameTb.Value = TeachersGV.SelectedRow.Cells[2].Text;
            TeacherPhoneTb.Value = TeachersGV.SelectedRow.Cells[3].Text;
            TeacherAddressTb.Value = TeachersGV.SelectedRow.Cells[4].Text;
            TeacherEmailTb.Value = TeachersGV.SelectedRow.Cells[5].Text;
            TeacherGenderTb.Value = TeachersGV.SelectedRow.Cells[6].Text;
            PasswordTb.Value = TeachersGV.SelectedRow.Cells[7].Text;
            if (TeacherNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TeachersGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TeacherNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Select a Teacher";
                }
                else
                {
                    string Query = "DELETE FROM TeachersTb WHERE TeacherId = {0} ";
                    Query = string.Format(Query, TeachersGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowTeachers();
                    ErrMsg.InnerText = "Teacher Deleted !!!";
                    Key = 0;
                    TeacherNameTb.Value = "";
                    TeacherPhoneTb.Value = "";
                    TeacherAddressTb.Value = "";
                    TeacherEmailTb.Value = "";
                    TeacherGenderTb.Value = "";
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
                string RName = TeacherNameTb.Value;
                string RPhone = TeacherPhoneTb.Value;
                string RAdd = TeacherAddressTb.Value;
                string REmail = TeacherEmailTb.Value;
                string RGender = TeacherGenderTb.Value;
                string Password = PasswordTb.Value;
                string Query = "update TeachersTb set TeacherName = '{0}' , TeacherPhone = '{1}' , TeacherAddress = '{2}', TeacherEmail = '{3}' , TeacherGender = '{4}' , Password = '{5}' where TeacherId = {6} ";
                Query = string.Format(Query, RName, RPhone, RAdd, REmail, RGender, Password, TeachersGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ShowTeachers();
                ErrMsg.InnerText = "Teacher Updated !!!";
                TeacherNameTb.Value = "";
                TeacherPhoneTb.Value = "";
                TeacherAddressTb.Value = "";
                TeacherEmailTb.Value = "";
                TeacherGenderTb.Value = "";
                PasswordTb.Value = "";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}