using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCoins.Models;

namespace MyCoins.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<Coin> _coins;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _coins = new CoinsData().Coins.ToList();

    }

    public IActionResult Index()
    {
        return View(_coins);
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
