using SOLUTIONS.GALAXY.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Domain.Interfaces.Repositories
{
    public interface IHologramRepository
    {
        IList<Hologram> GetAllByActive();
        IList<Hologram> GetAll();
        Hologram GetById(int id);

    }
}
