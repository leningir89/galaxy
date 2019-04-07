using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Infraestructure.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Web.Models
{
    public class JediViewModel
    {
        public IList<Jedi> Jedis { get; set; }
        public string SelectGrade { get; set; }
        public Jedi Jedi { get; set; }
    }
}
