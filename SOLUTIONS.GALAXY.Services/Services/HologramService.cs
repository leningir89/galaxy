using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Interfaces.Repositories;
using SOLUTIONS.GALAXY.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace SOLUTIONS.GALAXY.Services.Services
{
    public class HologramService : IHologramService
    {
        private readonly IHologramRepository hologramRepository;
        private readonly IOrderHologramsService oderHologramsService;
        private readonly IJediService jediService;

        public HologramService(IHologramRepository _hologramRepository, IOrderHologramsService _oderHologramsService,
            IJediService _jediService)
        {
            hologramRepository = _hologramRepository;
            oderHologramsService = _oderHologramsService;
            jediService = _jediService;
        }

        public IEnumerable<HologramList> GetAll()
        {
            var OrderHologramsList = new List<HologramList>();
            var holograms = hologramRepository.GetAll();

            foreach (var hologram in holograms)
            {
                var orders = oderHologramsService.GetByHologramdId(hologram.Id).ToList();
                OrderHologramsList.Add(new HologramList
                {
                    Id = hologram.Id,
                    Duration = hologram.Duration,
                    Name = hologram.Name,
                    Status = hologram.Status,
                    Jedis = GetJedis(orders.Where(x => x.HologramId == hologram.Id).ToList())
                });
            }

            return OrderHologramsList;
        }
        private List<Jedi> GetJedis(List<OrdersHolograms> ordersHolograms)
        {
            var jedis = new List<Jedi>();
            foreach (var orders in ordersHolograms)
            {
                var jedi = jediService.GetById(orders.JediId);
                jedis.Add(jedi);
            }
            return jedis;
        }

        public Hologram GetById(int id)
        {
            return hologramRepository.GetById(id);
        }

        public IEnumerable<Hologram> GetHologramsAcitve()
        {
            return hologramRepository.GetAllByActive();
        }
    }
}
