using System.ComponentModel.DataAnnotations;

namespace MarcasAuto.Domain.Entities
{
    public class MarcasAutoEntity
    {
        public string Id { get; set; } = string.Empty;

        [Required]
        public string Make { get; set; } = string.Empty;
    }
}
