using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyExamSystem.BLL;
using MyExamSystem.Models;

namespace MyExamSystem.View
{
    public partial class StudentDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int stuId=Convert.ToInt32(Request.QueryString["StuId"]);
                //根据id查学生信息
                //学生的信息展示在页面上
                Student stu=StudentManager.GetStudentById(stuId);
                this.stuId.Text = stu.StuID.ToString();
                this.stuName.Text = stu.StuName;
                this.stuLoginName.Text = stu.StuLoginName;
                if (stu.StuSex)
                {
                    //数据库的男女用bool表示，需要转化一下
                    this.stuSex.Text = "男";
                }
                else
                {
                    this.stuSex.Text = "女";
                }
                this.stuPhone.Text = stu.StuPhone;
                this.stuEmai.Text = stu.StuEmail;
                this.stuGrade.Text = stu.StuGrade;
            }
            
        }
    }
}