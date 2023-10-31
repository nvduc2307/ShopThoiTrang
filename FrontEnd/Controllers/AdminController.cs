using System.Collections.Generic;
using FrontEnd.Databases;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        var url = "http://localhost:8080";
        var urlbase = "/api/products";
        var contentJson = FetchApi.FetchGet(url, urlbase);
        Console.WriteLine(contentJson);
        // var products = JsonConvert.DeserializeObject<List<Product>>(contentJson);
        return View();
    }

    public IActionResult CreateProduct()
    {
        return View();
    }
}