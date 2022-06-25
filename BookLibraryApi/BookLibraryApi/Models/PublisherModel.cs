using ApplicationCore.Entities;

namespace BookLibraryWebAPI.Models
{
    public class PublisherModel
    {
        public string? Name { get; set; }
        public ICollection<Book>? Books { get; set; }

    }
}
