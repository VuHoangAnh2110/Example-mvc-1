using Microsoft.EntityFrameworkCore;
using Example_mvc_1.Models;

namespace Example_mvc_1.Data;

public class ApplicationDBContext :DbContext {
    public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options) : base(options){
        
    }

    public DbSet<BookEntity> Books { get; set; }
}

