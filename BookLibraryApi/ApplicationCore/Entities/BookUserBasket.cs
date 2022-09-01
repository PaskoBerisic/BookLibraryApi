namespace ApplicationCore.Entities
{
    public class BookUserBasket
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int UserBasketId { get; set; }
        public UserBasket UserBasket { get; set; }
    }
}
