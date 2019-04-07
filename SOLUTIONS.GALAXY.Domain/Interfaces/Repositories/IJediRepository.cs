using SOLUTIONS.GALAXY.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Domain.Interfaces.Repositories
{
    public interface IJediRepository
    {
        IList<Jedi> GetAll();
        IList<Jedi> GetByFilterGrade(short grade);
        bool Add(Jedi jedi);
        bool Edit(Jedi jedi);
        bool ChangeStatus(int id, bool status);
        Jedi GetById(int id);
    }
}
