using Microsoft.AspNetCore.Mvc;
using DAL;
using BOL;
namespace ReactWebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{


    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    
    public IEnumerable<Employee> Get(){
        Console.WriteLine("In api get");
            return Empdbmanager.GetAllEmployees().ToArray();
    }
}
