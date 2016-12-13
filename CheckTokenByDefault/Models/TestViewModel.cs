using System.ComponentModel.DataAnnotations;

namespace CheckTokenByDefault.Models
{
    public class TestViewModel
    {
        [Required]
        public string SomeString { get; set; }
    }
}