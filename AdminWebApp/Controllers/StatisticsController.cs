using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace AdminWebApp.Controllers
{
   [Route("Statistics")]
    public class StatisticsController : Controller
    {
        private readonly DataLayer.AppContext _context;

        public StatisticsController(DataLayer.AppContext context)
        {
            this._context = context;
        }
        [Route("")]
        public IActionResult Stats()
        {

            List<StudentModel> students = (List<StudentModel>) GetAll();
            List<SubjectModel> subjects = (List<SubjectModel>)GetAll2();
            
            var oops_max = students.Max(stud => stud.OOPS_001);
            var oops_min = students.Min(stud => stud.OOPS_001);
            var ds_max = students.Max(stud => stud.DS_002);
            var ds_min = students.Min(stud => stud.DS_002);
            var oops_avg = students.Average(stud => stud.OOPS_001);
            var ds_avg = students.Average(stud => stud.DS_002);
            var user_with_max_mks_oops = from stud in students
                                where stud.OOPS_001 == oops_max
                                select new { UserId = stud.ID, UserName = stud.Name };
            var user_with_max_mks_ds = from stud in students
                                         where stud.DS_002 == ds_max
                                         select new { UserId = stud.ID, UserName = stud.Name };
            var user_with_min_mks_oops = from stud in students
                                         where stud.OOPS_001 == oops_min
                                         select new { UserId = stud.ID, UserName = stud.Name };
            var user_with_min_mks_ds = from stud in students
                                       where stud.DS_002 == ds_min
                                       select new { UserId = stud.ID, UserName = stud.Name };
            Response.Cookies.Append("studentCount", students.Count().ToString());
            Response.Cookies.Append("subjectCount", subjects.Count().ToString());
            Response.Cookies.Append("max_oops", oops_max.ToString());
            Response.Cookies.Append("min_oops", oops_min.ToString());
            Response.Cookies.Append("max_ds", ds_max.ToString());
            Response.Cookies.Append("min_ds", ds_min.ToString());
            Response.Cookies.Append("avg_oops", oops_avg.ToString());
            Response.Cookies.Append("avg_ds", ds_avg.ToString());
            var obj1 = user_with_max_mks_oops.ToArray()[0];
            var obj2 = user_with_min_mks_oops.ToArray()[0];
            var obj3 = user_with_max_mks_ds.ToArray()[0];
            var obj4 = user_with_min_mks_ds.ToArray()[0];
            Response.Cookies.Append("stud_max_oops", "Name of the student: "+obj1.UserName);
            Response.Cookies.Append("stud_min_oops", "Name of the student: "+obj2.UserName);
            Response.Cookies.Append("stud_max_ds", "Name of the student: " + obj3.UserName);
            Response.Cookies.Append("stud_min_ds", "Name of the student: " + obj4.UserName);

            return View("Index");
        }
        [NonAction]
        public IEnumerable<StudentModel> GetAll()
        {
            return this._context.Set<StudentModel>().ToList();
        }
        [NonAction]
        public IEnumerable<SubjectModel>GetAll2()
        {
            return this._context.Set<SubjectModel>().ToList();
        }
    }
}
