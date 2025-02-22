using System.ComponentModel.DataAnnotations;

namespace OllamaBlazorAspireDemo.Data.Entities
{
    public class UserChat
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ChatTitle { get; set; }
        public DateTime CreaionTime { get; set; }
        public ApplicationUser User { get; set; }
        public string ChatJson { get; set; }
    }
}
