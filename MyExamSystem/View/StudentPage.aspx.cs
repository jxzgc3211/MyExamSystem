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
    public partial class StudentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //页面运行时，加载全部学生信息
            MyDataBind();
        }
        public void MyDataBind()
        {
            //查询所有学生信息，将数据绑定到repeator控件上
            //查询学生信息
            List<Student> list = StudentManager.GetAllStudent();
            //数据绑定
            this.Repeate1.DataSource = list;
            this.Repeate1.DataBind();
        }
    }
}