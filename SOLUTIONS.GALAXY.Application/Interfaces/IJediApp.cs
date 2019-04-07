using SOLUTIONS.GALAXY.Domain.Entities;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Application.Interfaces
{
    public interface IJediApp
    {
        IList<Jedi> GetAll();
        string Creat(Jedi jedi);
        string Edit(Jedi jedi);
        string ChangeStatus(int id);
        IList<Jedi> GetByGrade(string grade);
        Jedi GetById(int id);
    }
}
