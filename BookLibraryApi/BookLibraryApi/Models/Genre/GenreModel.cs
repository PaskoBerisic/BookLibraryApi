using ApplicationCore.Entities;
using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models
{
    public class GenreModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<BookModel>? Books { get; set; }
        public string? Description { get; set; }
    }
}
