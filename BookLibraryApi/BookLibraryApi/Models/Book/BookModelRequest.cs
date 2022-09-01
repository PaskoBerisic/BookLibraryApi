namespace BookLibraryApi.Models
{
    public class BookModelRequest
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int YearOfPublish { get; set; }
        public string? Description { get; set; }
        public decimal RentalPrice { get; set; }
        public int UnitNumber { get; set; }
        public int UnitsRented { get; set; }

        public int? PublisherId { get; set; }
        public int? LanguageId { get; set; }
        public ICollection<int>? AuthorIds { get; set; }
        public ICollection<int>? GenreIds { get; set; }
    }
}
