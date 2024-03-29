﻿namespace ApplicationCore.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int YearOfPublish { get; set; }
        public string? Description { get; set; }
        public decimal RentalPrice { get; set; }
        public decimal ListPrice { get; set; }
        public int UnitNumber { get; set; }
        public int UnitsRented { get; set; }

        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updated { get; set; }

        // One to Many
        public int LanguageId { get; set; }
        public Language? Language { get; set; }
        public int PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
        // Many to Many
        public ICollection<BookAuthor>? BookAuthors { get; set; }
        public ICollection<BookGenre>? BookGenres { get; set; }
        public ICollection<BookUserBasket>? BookUserBaskets { get; set; }
        public ICollection<BookOrder>? BookOrders { get; set; }
    }
}
