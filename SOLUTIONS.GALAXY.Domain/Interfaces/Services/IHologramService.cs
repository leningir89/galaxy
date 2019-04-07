using SOLUTIONS.GALAXY.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Domain.Interfaces.Services
{
    public interface IHologramService
    {
        Hologram GetById(int id);
        IEnumerable<HologramList> GetAll();
        IEnumerable<Hologram> GetHologramsAcitve();
    }
}
