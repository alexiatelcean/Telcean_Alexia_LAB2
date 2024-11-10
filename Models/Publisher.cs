namespace Telcean_Lorena_Alexia_LAB2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }  //navigation property 
    }
}
