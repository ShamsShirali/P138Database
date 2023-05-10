namespace P138Database.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public Model Model { get; set; }
    }
}
