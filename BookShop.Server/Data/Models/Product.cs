using System.ComponentModel.DataAnnotations;
using static BookShop.Server.Data.Validation.Product;
namespace BookShop.Server.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ImageLink { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }

        [MaxLength(MaxDescriptionLenght)]
        public string Description { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
    }
}
