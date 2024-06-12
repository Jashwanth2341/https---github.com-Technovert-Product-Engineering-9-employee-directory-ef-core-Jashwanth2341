using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeRoleEf.Models;

namespace EmployeeRoleEf.Controllers;

public class HomeController : Controller
{
    private readonly EmployeeDbContext employeeDb;

    /**private readonly ILogger<HomeController> _logger;

public HomeController(ILogger<HomeController> logger)
{
_logger = logger;
}*/
    public HomeController(EmployeeDbContext employeeDb)
    {
        this.employeeDb = employeeDb;

    }
    public IActionResult Index()

    {
        // var stddata = employeeDb.employees.ToList();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
