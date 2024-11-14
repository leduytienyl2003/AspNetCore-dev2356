using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId {  get; set; }
        public int GenresId {  get; set; }
        public string Image {  get; set; }
        public float Price {  get; set; }
        public int TotalPage {  get; set; }
        public string Sumary {  get; set; }

        //danh sách các cuốn sách (nhớ using system.colletions.Generic)
        public List<Book> GetBookList()
        {
            List<Book> Books = new List<Book>();
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chi Pheo",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/images/products/1.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                };
                new Book()
                {
                    Id = 2,
                    Title = "Chi Pheo",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/images/products/2.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                };
                new Book()
                {
                    Id = 3,
                    Title = "Chi Pheo",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/images/products/3.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                };
                new Book()
                {
                    Id = 4,
                    Title = "Chi Pheo",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/images/products/4.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                };
                new Book()
                {
                    Id = 5,
                    Title = "Chi Pheo",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/images/products/3.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                };
                new Book()
                {
                    Id = 6,
                    Title = "Chi Pheo",
                    AuthorId = 1,
                    GenresId = 1,
                    Image = "/images/products/2.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                };
                
            };
            return Books;
        }

        //chi tiết một cuốn sách theo id (using system.Linq)
        public Book GetBookById(int id)
        {
            Book book=this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        //selectionListItem Authors (using Microsort.AspNetCore.Mvc.Rendering)
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="1",Text="Nam cao"},
            new SelectListItem {Value="2",Text="David Tiến"},
            new SelectListItem {Value="3",Text="Ngô tất tố"},
            new SelectListItem {Value="4",Text="Thích đủ món"},
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="1",Text="Truyện tranh"},
            new SelectListItem {Value="2",Text="tiểu thuyết"},
            new SelectListItem {Value="3",Text="phật học phổ thông"},
            new SelectListItem {Value="4",Text="ngôn tình"},
        };

    }
}
