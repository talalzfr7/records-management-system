using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class Client
    {
        public int ID { get; set; } 
        public string Name { get; set; } = "";

        public string Department { get; set; } = "";

        public string Phone { get; set; } = "";


    }
}
