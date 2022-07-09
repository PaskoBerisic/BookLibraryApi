namespace ApplicationCore.Entities
{
    public class SystemSettings
    {
        public int Id { get; set; }
        public string? DefaultCurrency { get; set; }
        // One to Many
        public int LanguageId { get; set; }
        public Language? Language { get; set; }
    }
}
