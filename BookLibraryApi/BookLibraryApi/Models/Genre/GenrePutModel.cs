using ApplicationCore.Entities;

namespace BookLibraryApi.Models
{
    public class GenrePutModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }
}
