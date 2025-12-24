using System.ComponentModel.DataAnnotations;

namespace BlazorApp123.Models
{
    public class ClientDto
    { 
        public string Name { get; set; } = "";
        public string? Department { get; set; }
        public string? Phone { get; set; }
    }
}
