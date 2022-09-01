namespace BookLibraryApi.Models
{
    public class GenreModelRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public ICollection<int>? BookIds { get; set; }
    }
}
