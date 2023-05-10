namespace P138Database.Models
{
    public class Model
    {
        public int Id { get; set; }
        public int MarkaId { get; set; }
        public string Name { get; set; }
        public Marka Marka { get; set; }
    }
}
