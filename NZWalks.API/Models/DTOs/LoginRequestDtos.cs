using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace NZWalks.API.Models.DTOs
{
    public class LoginRequestDtos
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
