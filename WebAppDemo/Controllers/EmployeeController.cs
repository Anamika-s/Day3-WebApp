using Microsoft.AspNetCore.Mvc;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees = null;
        public EmployeeController()
        {
            if(employees == null)
            {
                employees = new List<Employee>()
                {
                     new    Employee() {Id=1, Name="ajay", Dept="hr", Salary=21000},

                     new    Employee() {Id=1, Name="ajay", Dept="hr", Salary=21000},

                     new    Employee() {Id=1, Name="ajay", Dept="hr", Salary=21000},

                     new    Employee() {Id=1, Name="ajay", Dept="hr", Salary=21000}
                };
            }
        }
        public IActionResult Index()
        {

            return View(employees.ToList());
        }
    }
}
