using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/gallery")]
        public IActionResult Gallery()
        {
            var gallery = new Gallery("Породы собак");

            gallery.Images.Add(new Image("#1", "https://images.unsplash.com/photo-1554110397-9bac083977c6?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80"));
            gallery.Images.Add(new Image("#2", "https://images.unsplash.com/photo-1554034483-04fda0d3507b?ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80"));
            gallery.Images.Add(new Image("#3", "https://images.unsplash.com/photo-1554381316-e7ae6a16bdf4?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=751&q=80"));
            gallery.Images.Add(new Image("#4", "https://images.unsplash.com/photo-1554198479-6e76813bc099?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=741&q=80"));
            //gallery.Images.Add(new Image("Антон", "https://pp.userapi.com/c845216/v845216954/15755c/kr4nB7w0sbE.jpg"));

            return Json(gallery);
        }
    }
}
