using System.ComponentModel.DataAnnotations;

namespace BtcTransmuter.Models
{
    public class CreateRecipeViewModel
    {
        public string StatusMessage { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }
    }
}