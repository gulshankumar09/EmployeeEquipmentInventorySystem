using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models;

namespace EEIMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepo;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepo = employeeRepository;
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
             try
                {
                    _employeeRepo.Add(employee);
                    _employeeRepo.Commit();
                    return RedirectToAction("AddEmployee");
                }
                catch (Exception ex)
                {
                    // Handle or log the exception, and return an error view or message.
                    ModelState.AddModelError(string.Empty, "An error occurred while adding the employee." + ex);
                    return View(employee);
                }

        }


        public ActionResult GetEmployees()
        {
            var employees = _employeeRepo.GetAll().ToList();
            return View(employees);
        }
    }
}