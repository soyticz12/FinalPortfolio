namespace JhonCarloJadocWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }  // Unique identifier
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
