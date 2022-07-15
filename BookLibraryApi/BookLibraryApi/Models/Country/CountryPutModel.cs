namespace BookLibraryApi.Models.Country
{
    public class CountryPutModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public int VAT { get; set; }
    }
}
