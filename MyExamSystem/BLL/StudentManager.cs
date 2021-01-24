using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyExamSystem.DAL;
using MyExamSystem.Models;

namespace MyExamSystem.BLL
{
    public class StudentManager
    {
        public static bool CheckStudentUser(string name,string pwd)
        {
            Student s=StudentServer.SelectStudentByName(name);
            //不为空，表示查询到了一条学生信息的记录
            if (s != null)
            {
                return s.StuLoginPwd == pwd;
            }
            else
            {
                return false;
            }
          
        }
        public static List<Student> GetAllStudent()
        {
            return StudentServer.SelectAllStudent();
        }
    }
}