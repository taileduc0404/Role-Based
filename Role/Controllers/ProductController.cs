using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Role.Constants;

namespace Role.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
