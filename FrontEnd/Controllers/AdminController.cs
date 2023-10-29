using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers;
public class AdminController : Controller {
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }
    //[GET] /admin
    public IActionResult Index()
    {
        return View();
    }

    //[GET] /admin/products
    public IActionResult Products()
    {
        return View();
    }

    public IActionResult CreateProduct()
    {
        return View();
    }
}