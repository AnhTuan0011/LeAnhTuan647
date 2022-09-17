using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LeAnhTuanBTH.Models;
using LeAnhTuanBTH.Controllers;


namespace LeAnhTuanBTH.Controllers;
public class StudentController : Controller
{

    public IActionResult Index()
    {
        //khoi toa list studen
        List<Student> stdList = new List<Student>()
        {
            new Student {StudentID = 1, StudentName = "Nguyen Van A", StudentAge = 18},
            new Student {StudentID = 2, StudentName = "Nguyen Van B", StudentAge = 18},
            new Student {StudentID = 3, StudentName = "Nguyen Van C", StudentAge = 18},
            new Student {StudentID = 4, StudentName = "Nguyen Van D", StudentAge = 18},
            new Student {StudentID = 5, StudentName = "Nguyen Van E", StudentAge = 18}
        };
        ViewData["Students"] = stdList;
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student std)
    {
        //string message = std.Student + "-";
        //message += std.StudentName + "-";
        //message += std.Age;
        //ViewBag.TT = message;
        return View();
    }
}