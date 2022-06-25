using ApplicationCore.Entities;

namespace BookLibraryWebAPI.Models
{
    public class GenresModel
    {
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Book>? Books { get; set; }
        public string? Description { get; set; }

    }
}
