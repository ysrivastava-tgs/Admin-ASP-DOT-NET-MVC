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
    public class SubjectController : BaseController<SubjectController, SubjectModel>
    {
        //private readonly IBaseRepository<EmployeeModel> _repo;

        public SubjectController(IBaseRepository<SubjectModel> repo) : base(repo)
        {

        }

        // GET: Employee

    }
}
