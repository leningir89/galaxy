using SOLUTIONS.GALAXY.Domain.Enums;
using SOLUTIONS.GALAXY.Infraestructure.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SOLUTIONS.GALAXY.Domain.Entities
{
    public class Jedi : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public short Age { get; set; }
        [Required]
        public Grade Grade { get; set; }
        [Required]
        public LightsaberColor LightsaberColor { get; set; }
        public short GradeId { get; set; }
        public short LightsaberColorId { get; set; }
    }
}
