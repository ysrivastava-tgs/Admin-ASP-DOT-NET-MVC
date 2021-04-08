using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Models;
using AppContext = DataLayer.AppContext;

namespace AdminWebApp.Controllers
{
    public class StudentController : BaseController<StudentController, StudentModel>
    {
        //private readonly IBaseRepository<EmployeeModel> _repo;

        public StudentController(IBaseRepository<StudentModel> repo) : base(repo)
        {

        }

        // GET: Employee

    }
}
