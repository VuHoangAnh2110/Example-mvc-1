using System.ComponentModel.DataAnnotations;

namespace Example_mvc_1.Models;

public class BookEntity {
    
    [Required(ErrorMessage = "Không được để trống")]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

}