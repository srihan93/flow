
using System.ComponentModel.DataAnnotations;

namespace Flows.ServiceHost.Models
{
    public class Credential
    {
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
