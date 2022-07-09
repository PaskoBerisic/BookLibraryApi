namespace BookLibraryApi.Models.Publisher
{
    public class PublisherPostModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        // Many to Many
        //public ICollection<BookModelShort>? Books { get; set; }
    }
}
