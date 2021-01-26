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
                ////查询出来一个student
                //Student stu = StudentServer.SelectStudentByID(s.StuID);
                //ExamDBEntities db = new ExamDBEntities();
                //db.Entry(stu).State = EntityState.Modified;
                ////逐个更新
                //stu.StuName = s.StuName;
                //stu.StuLoginName = s.StuLoginName;
                //stu.StuSex = s.StuSex;
                //stu.StuGrade = s.StuGrade;
                //stu.StuEmail = s.StuEmail;
                //stu.StuLoginPwd = s.StuLoginPwd;
                //stu.StuPhone = s.StuPhone;

                //查询出来一个student                
                Student stu = StudentServer.SelectStudentByID(s.StuID);
                ExamDBEntities db = new ExamDBEntities();
                //这也可以实现对象的快速修改，推荐用这个方法
                db.Entry(s).State = EntityState.Modified;    //直接将传入的对象，设置修改装填           
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }            
        }
        public static bool DeleteStudentByID(int id)
        {
            try
            {
                //获取要删除的学生信息
                Student s = StudentServer.SelectStudentByID(id);
                ExamDBEntities db = new ExamDBEntities();
                //将要删除的学生对象状态，修改为删除。
                db.Entry(s).State = EntityState.Deleted;
                db.Students.Remove(s);//Remove删除
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            } 
        }
        public static bool AddStudent(Student s)
        {
            using(ExamDBEntities db=new ExamDBEntities())
            {
                try
                {
                    db.Entry(s).State = EntityState.Added;//也可以不加，因为Add时，会自动修改状态
                    db.Students.Add(s);
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
}