using System.ComponentModel.DataAnnotations;

namespace Taskist.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public required string Content { get; set; }
            
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
