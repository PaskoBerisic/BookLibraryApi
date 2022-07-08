namespace BookLibraryApi.Models.Language
{
    public class LanguageModelRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public ICollection<BookModel>? Books { get; set; }

    }
}
