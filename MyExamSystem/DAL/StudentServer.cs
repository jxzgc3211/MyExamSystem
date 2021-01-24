using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyExamSystem.Models;

namespace MyExamSystem.DAL
{
    public class StudentServer
    {
        public static Student SelectStudentByName(string name)
        {
            using (ExamDBEntities db = new ExamDBEntities())
            {
                Student s = db.Students.FirstOrDefault(stu => stu.StuLoginName == name);
                return s;
            }
        }
        public static List<Student> SelectAllStudent()
        {
            using(ExamDBEntities db=new ExamDBEntities())
            {
               return  db.Students.ToList();
            }
        }
    }
}