// Được sử dụng để truy cập các thông tin về hoạt động của ứng dụng, ví dụ: lấy ID hoạt động hiện tại (Activity ID).
using System.Diagnostics; 
// Chứa các lớp và thuộc tính cần thiết để làm việc với ASP.NET Core MVC, bao gồm Controller.
using Microsoft.AspNetCore.Mvc;
// Tham chiếu đến không gian tên của các model trong dự án, cụ thể ở đây là ErrorViewModel.
using Example_mvc_1.Models;

namespace Example_mvc_1.Controllers;

public class HomeController : Controller
{
    // Một logger được tiêm vào (injected) để ghi lại các log.
    // ASP.NET Core sử dụng dependency injection (DI) để tự động cấp logger này.
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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
