using MyExamSystem.BLL;
using MyExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyExamSystem.View
{
    public partial class StudentModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //填充数据
            if (!IsPostBack)
            {
                int stuId = Convert.ToInt32(Request.QueryString["StuId"]);
                //根据id查学生信息
                //学生的信息展示在页面上
                Student stu = StudentManager.GetStudentById(stuId);
                this.stuId.Text = stu.StuID.ToString();
                this.stuName.Text = stu.StuName;
                this.stuLoginName.Text = stu.StuLoginName;
                this.stuPhone.Text = stu.StuLoginPwd;
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

        protected void stuUpdate_Click(object sender, EventArgs e)
        {
            //1、重新获取文本框中的内容
            //2、将用户修改的内容，封装到student对象中进行传递
            //3、调用业务层的更新方法进行数据更新
            //4、返回首页，查看更新的效果
            Student s = new Student();
            s.StuID = Convert.ToInt32(this.stuId.Text);
            s.StuName = this.stuName.Text;
            if (this.stuSex.Text == "男")
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

            /*
             更新的实现过程：
            1、根据条件(学生ID)，从数据查找需要更新的记录
            2、通过督办context对象设置要更新的对象，将该对象的状态改为modified
            3、将更新记录对象的属性以一个更改，再调用savechanges()
             */
            if (StudentManager.UpdateStudentInfo(s))
            {
                Response.Redirect("StudentPage.aspx");
            }
            
        }
    }
}