using CarTask.Models;

namespace CarTask.Models
{
    public class Marka
    {

        public int Id { get; set; }

        public string MarkaName { get; set; }

        public List<Model > Models { get; set; }
    }
}
