using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ClientDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = "";

        public string? Department { get; set; }

        [Phone]
        public string? Phone { get; set; }
    }
}


