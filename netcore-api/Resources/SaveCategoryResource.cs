using System.ComponentModel.DataAnnotations;

namespace netcore_api.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}