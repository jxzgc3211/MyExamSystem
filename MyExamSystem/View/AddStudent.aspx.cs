using MyExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyExamSystem.BLL;

namespace MyExamSystem.View
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
           
            s.StuName = this.stuName.Text;
            if (this.rbNan.Checked)
            {
                s.StuSex = true;
            }
            else
            {
                s.StuSex = false;
            }
            s.StuLoginName = this.stuLoginName.Text;
            s.StuLoginPwd = this.stuPwd.Text;
            s.StuPhone = this.stuPhone.Text;
            s.StuEmail = this.stuEmai.Text;
            s.StuGrade = this.stuGrade.Text;
            if (StudentManager.AddStudent(s))
            {
                Response.Redirect("StudentPage.aspx");
            }
            else
            {
                Response.Write("添加学生失败~");
            }
            
        }
    }
}