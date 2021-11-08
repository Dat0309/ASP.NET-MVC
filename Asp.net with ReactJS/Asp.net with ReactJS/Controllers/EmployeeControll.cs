using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Asp.net_with_ReactJS.Models;

namespace Asp.net_with_ReactJS.Controllers
{
    // All business logic in place here
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeControll : ControllerBase
    {
        EmployeeDataAccessLayer _dataAccessLayer =new EmployeeDataAccessLayer();

        [HttpGet]
        [Route("api/Employeee/Index")]
        public IEnumerable<TblEmployee> Index()
        {
            return _dataAccessLayer.GetAllEmployees();
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create(TblEmployee employee)
        {
            return _dataAccessLayer.AddEmployee(employee);
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public TblEmployee Details(int id)
        {
            return _dataAccessLayer.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit(TblEmployee employee)
        {
            return _dataAccessLayer.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return _dataAccessLayer.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("api/Employee/GetCityList")]
        public IEnumerable<TblCity> Details()
        {
            return _dataAccessLayer.GetCities();
        }
    }
}
