using ajax_form_and_validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ajax_form_and_validation.Context;

namespace ajax_form_and_validation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _context;
        private readonly IWebHostEnvironment env;
        

        public HomeController(ILogger<HomeController> logger,DatabaseContext context,IWebHostEnvironment env)
        {
            _logger = logger;
            this._context = context;
            this.env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public JsonResult Addstudent(Student data)
        {
            string path = "/images/";
            path += new Guid()+data.imagefile.FileName;

            string serverpath= env.WebRootPath +path;
            
            data.imagefile.CopyToAsync(new FileStream(serverpath, FileMode.Create));
            var student = new Student()
            {
                Name = data.Name,
                Address = data.Address,
                imageurl = path,
            };
            _context.Students.Add(student);
            _context.SaveChanges();
            return Json("data added");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
