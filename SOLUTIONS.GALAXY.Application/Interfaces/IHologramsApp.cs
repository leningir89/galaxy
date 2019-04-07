using SOLUTIONS.GALAXY.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Application.Interfaces
{
    public interface IHologramsApp
    {
        IEnumerable<HologramList> GetAll();
        IList<Hologram> GetHologramsActive();
    }
}
