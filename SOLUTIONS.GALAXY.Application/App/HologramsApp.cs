using SOLUTIONS.GALAXY.Application.Interfaces;
using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace SOLUTIONS.GALAXY.Application.App
{
    public class HologramsApp : IHologramsApp
    {
        private readonly IHologramService hologramsService;

        public HologramsApp(IHologramService _hologramsService)
        {
            hologramsService = _hologramsService;
        }

        public IEnumerable<HologramList> GetAll()
        {
            return hologramsService.GetAll();
        }

        public IList<Hologram> GetHologramsActive()
        {
            return hologramsService.GetHologramsAcitve().ToList();
        }
    }
}
