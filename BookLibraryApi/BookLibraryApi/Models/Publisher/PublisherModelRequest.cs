namespace BookLibraryApi.Models.Publisher
{
    public class PublisherModelRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<BookModel>? Books { get; set; }


    }
}
