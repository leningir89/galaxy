using SOLUTIONS.GALAXY.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTIONS.GALAXY.Domain.Interfaces.Services
{
    public interface IJediService
    {
        IList<Jedi> GetAll();
        IList<Jedi> GetByFilterGrade(short grade);
        bool Add(Jedi jedi);
        bool Edit(Jedi jedi);
        bool ChangeStatus(int id, bool status);
        Jedi GetById(int id);
    }
}
