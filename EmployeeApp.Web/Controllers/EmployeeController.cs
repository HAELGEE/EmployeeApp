using EmployeeApp.Web.Models;
using EmployeeApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Web.Controllers;
public class EmployeeController : Controller
{
    EmployeeService employeeService = new EmployeeService();

    // Alla anställda
    [Route("")]
    public IActionResult Index()
    {
        Employee[] emplyoees = employeeService.GetAll();

        return View(emplyoees);
    }

    // Skapa Anställd
    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost("create")]
    public IActionResult Create(Employee employee)
    {
        if (!ModelState.IsValid)
            return View();


        employeeService.Add(employee);
        return RedirectToAction(nameof(Index));
    }

    //Hämta info om Anställd
    [HttpGet("info/{employeeId}")]
    public IActionResult Info(int employeeId)
    {        
        return View(employeeService.GetById(employeeId));
    }

}
