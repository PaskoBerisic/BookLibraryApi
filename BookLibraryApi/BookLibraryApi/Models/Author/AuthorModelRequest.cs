namespace BookLibraryApi.Models
{
    public class AuthorModelRequest
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Bibliography { get; set; }
     
        public int? CountryId { get; set; }
        public ICollection<int>? BookIds { get; set; }
    }
}
