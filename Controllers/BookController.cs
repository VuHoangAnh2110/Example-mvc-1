using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Example_mvc_1.Models;
using Example_mvc_1.Data;
using System.Data.Common;

namespace Example_mvc_1.Controllers;

public class BookController : Controller {
    private ApplicationDBContext _db;

    public BookController(ApplicationDBContext db){
        _db = db;
    }

    // [Route("test1")]
    public IActionResult Index(){
        var books = _db.Books.ToList();
        return View(books);
    }

    public IActionResult Create(){
        return View();
    }
    // [HttpPost]
    // public IActionResult testPost (BookEntity test) {
    //     if(ModelState.IsValid){
    //     }
    // }

    
    // public IActionResult test (){
    //     // Danh sách sản phẩm mẫu
    //     var products = new List<BookEntity>
    //     {
    //         new BookEntity { Id = 1, Title = "Laptop" },
    //         new BookEntity { Id = 2, Title = "Smartphone" },
    //         new BookEntity { Id = 3, Title = "Tablet" }
    //     };

    //     // Truyền danh sách sản phẩm tới View
    //     return View(products);
    // }

}

