using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Enums;
using SOLUTIONS.GALAXY.Domain.Extensions;
using SOLUTIONS.GALAXY.Domain.Interfaces.Repositories;
using SOLUTIONS.GALAXY.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Services.Services
{
    public class JediService : IJediService
    {
        private readonly IJediRepository jediRepository;

        public JediService(IJediRepository _jediRepository)
        {
            jediRepository = _jediRepository;
        }
        public bool Add(Jedi jedi)
        {
            var newJedi = GetJediForOperations(jedi);
            return jediRepository.Add(newJedi);
        }

        public bool ChangeStatus(int id, bool status)
        {
            return jediRepository.ChangeStatus(id, status);
        }

        public bool Edit(Jedi jedi)
        {
            var newJedi = GetJediForOperations(jedi);
            return jediRepository.Edit(newJedi);
        }

        private Jedi GetJediForOperations(Jedi jedi)
        {
            jedi.GradeId = (short)jedi.Grade.ToString().ToEnum<Grade>();
            jedi.LightsaberColorId = (short)jedi.LightsaberColor.ToString().ToEnum<LightsaberColor>();
            return jedi;
        }

        public IList<Jedi> GetAll()
        {
            return jediRepository.GetAll();
        }

        public IList<Jedi> GetByFilterGrade(short grade)
        {
            return jediRepository.GetByFilterGrade(grade);
        }

        public Jedi GetById(int id)
        {
            var jedi = jediRepository.GetById(id);
            return GetJediForOperations(jedi);
        }
    }
}
