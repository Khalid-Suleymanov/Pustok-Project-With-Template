using System.ComponentModel.DataAnnotations;

namespace PustokTemplateTask.Models
{
    public class Feature
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(100)]
        public string Icon { get; set; }
    }
}
