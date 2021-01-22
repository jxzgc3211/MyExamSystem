﻿using MyExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyExamSystem.DAL
{
    /// <summary>
    /// 关于教师表的所有查询
    /// </summary>
    public class TeacherServer
    {
        public static Teacher SelectTeacherByUserName(string userName) {
            using (ExamDBEntities db=new ExamDBEntities()) {
              Teacher teacher= db.Teachers.SingleOrDefault(t => t.TeacherLoginName == userName);
                return teacher;
            }
        }
    }
}