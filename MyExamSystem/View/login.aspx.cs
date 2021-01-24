using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyExamSystem.BLL;//业务层

namespace MyExamSystem.View
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断前端传过来的typeId的值，1是教师登录，2是学生登录
            int id = Convert.ToInt32(Request.QueryString["typeId"]);
            if (id == 1)
            {
                Msg.Text = "教师登录";
                this.HiddenField1.Value = "1";//对隐藏域进行赋值
            }else if (id == 2)
            {
                Msg.Text = "学生登录";
                this.HiddenField1.Value = "2";
            }
            else
            {
                Msg.Text = "错误的登陆者";
                this.HiddenField1.Value = "0";
            }

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            //判断实际是谁在登录
            //1、获取用户名和密码框的数据
            //2、判断是1教师登录还是2学生登录
            //3、利用隐藏域获取值
            string name = this.UserName.Text;
            string pwd = this.PassWord.Text;
            string typeId = this.HiddenField1.Value;//获取隐藏域的值，用户识别登录用户的性质
            if (typeId == "1")
            {
                //教师登录，判断用户名、密码是否正确
                //实现用户名和密码验证，去数据库验证
                bool tea_result=TeacherManager.CheckTeacherUser(name, pwd);
                if (tea_result)
                {
                    //跳转到教师的管理界面
                    Session["userName"] = name;
                    Response.Redirect("TeacherHome.aspx");//页面跳转
                }
                else
                {
                    //显示提示信息
                    this.Msg.Text = "用户名或密码错误";
                }
            }
            //登录用户为学生的情况
            if (typeId == "2")
            {
                //学生登录，判断用户名、密码是否正确
                //实现用户名和密码验证
                bool stu_result = StudentManager.CheckStudentUser(name, pwd);
                if (stu_result)
                {
                    this.Msg.Text="学生登录成功";
                }
                else
                {
                    this.Msg.Text = "用户名或密码错误";
                }
            }
        }
    }
}