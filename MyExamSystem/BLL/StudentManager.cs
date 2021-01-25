using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyExamSystem.DAL;
using MyExamSystem.Models;
using System.Data.Entity;

namespace MyExamSystem.BLL
{
    public class StudentManager
    {
        public static bool CheckStudentUser(string name, string pwd)
        {
            Student s = StudentServer.SelectStudentByName(name);
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
        public static Student GetStudentById(int id)
        {
            return StudentServer.SelectStudentByID(id);
        }
        public static bool UpdateStudentInfo(Student s)
        {
            try
            {
                //查询出来一个student
                Student stu = StudentServer.SelectStudentByID(s.StuID);
                ExamDBEntities db = new ExamDBEntities();
                db.Entry(stu).State = EntityState.Modified;
                //逐个更新
                stu.StuName = s.StuName;
                stu.StuLoginName = s.StuLoginName;
                stu.StuSex = s.StuSex;
                stu.StuGrade = s.StuGrade;
                stu.StuEmail = s.StuEmail;
                stu.StuLoginPwd = s.StuLoginPwd;
                stu.StuPhone = s.StuPhone;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}