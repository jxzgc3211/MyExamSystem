using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyExamSystem.DAL;
using MyExamSystem.Models;

namespace MyExamSystem.BLL
{
    /// <summary>
    /// 业务层
    /// </summary>
    public class TeacherManager
    {
        //实现对教师用户的验证
        public static bool CheckTeacherUser(string userName,string passWord)
        {
            //根据条件获取teacher对象
            Teacher t=TeacherServer.SelectTeacherByUserName(userName);
            if (t != null)
            {
                //判断密码是否正确，正确返回为真，假：密码错误
                return t.TeacherLoginPwd == passWord;
            }
            else
            {
                return false;
            }
        }

    }
}