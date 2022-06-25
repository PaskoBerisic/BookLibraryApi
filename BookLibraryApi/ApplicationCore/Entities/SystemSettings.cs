namespace ApplicationCore.Entities
{
    public class SystemSettings
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language? Language { get; set; }
        public string? DefaultCurrency { get; set; }

    }
}
