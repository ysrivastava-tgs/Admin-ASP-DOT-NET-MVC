using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Models;

namespace AdminWebApp.Controllers
{

    public class ClassController : BaseController<ClassController, ClassModel>
    {
        //private readonly IBaseRepository<EmployeeModel> _repo;

        public ClassController(IBaseRepository<ClassModel> repo) : base(repo)
        {

        }

        // GET: Employee

    }
}
