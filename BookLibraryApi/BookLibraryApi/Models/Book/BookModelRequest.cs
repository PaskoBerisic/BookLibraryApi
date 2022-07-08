namespace BookLibraryApi.Models.Book
{
    public class BookModelRequest
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<AuthorModel>? Authors { get; set; }
        public PublisherModel? Publisher { get; set; }
        public int YearOfPublish { get; set; }
        public string? Description { get; set; }
        public ICollection<GenreModel>? Genres { get; set; }
        public LanguageModel? Language { get; set; }
        public decimal RentalPrice { get; set; }
        public int UnitNumber { get; set; }
    }
}
