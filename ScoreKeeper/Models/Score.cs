using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models 
{
    public class Score
    {
        public virtual int Id { get; set; }
        public virtual Player Player { get; set; }
        [Required]
        [Range(0,25)]
        public virtual int Value { get; set; }
    }
}