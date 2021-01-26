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
            if (!IsPostBack)
            {
                //页面运行时，加载全部学生信息
                //★★★★2021-1-26，数据绑定放入页面首次加载时。
                //当后续数据更新后，再调用该方法就不会在报未验证的奇怪错误。
                MyDataBind();

            }            
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

        protected void Repeate1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //相应删除按钮的操作
            if (e.CommandName == "del")
            {                
                //获取按钮带过来的id参数
                int id = Convert.ToInt32(e.CommandArgument.ToString());
                if (StudentManager.DeleteStudentByID(id))
                {
                    Response.Redirect("StudentPage.aspx");
                }
            }
        }
    }
}