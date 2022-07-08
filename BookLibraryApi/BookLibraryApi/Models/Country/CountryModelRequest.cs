namespace BookLibraryApi.Models.Country
{
    public class CountryModelRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public int VAT { get; set; }

    }
}
