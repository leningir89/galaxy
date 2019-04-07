using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Domain.Entities
{
    public class HologramList : Hologram
    {
        public IList<Jedi> Jedis { get; set; }
    }
}
