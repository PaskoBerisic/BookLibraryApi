namespace BookLibraryApi.Models.Genre
{
    public class GenreModelRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<BookModel>? Books { get; set; }
        public string? Description { get; set; }
    }
}
