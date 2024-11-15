using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Lesson06_TheoryCF8.Models
{
    public class BookManagementContext : DbContext
    {
        public BookManagementContext(DbContextOptions<BookManagementContext> options) : base(options) { }
        //khai báo các thuộc tính biểu diễn các thực thể
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}


