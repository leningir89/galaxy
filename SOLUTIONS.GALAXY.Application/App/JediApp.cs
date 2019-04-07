using SOLUTIONS.GALAXY.Application.Interfaces;
using SOLUTIONS.GALAXY.Application.Resources;
using SOLUTIONS.GALAXY.Domain.Entities;
using SOLUTIONS.GALAXY.Domain.Enums;
using SOLUTIONS.GALAXY.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SOLUTIONS.GALAXY.Application.App
{
    public class JediApp : IJediApp
    {
        private readonly IJediService jediService;

        public JediApp(IJediService _jediService)
        {
            jediService = _jediService;
        }

        public string ChangeStatus(int id)
        {
            var jedi = jediService.GetById(id);
            var result = jediService.ChangeStatus(id, !jedi.Status);
            if (result)
            {
                return Messages.ChangeStatusJedi;
            }
            return Messages.Error;
        }

        public string Creat(Jedi jedi)
        {
            var result = jediService.Add(jedi);
            if(result)
            {
                return Messages.CreateJediOk;
            }
            throw new Exception(Messages.Error);
        }

        public string Edit(Jedi jedi)
        {
            var result = jediService.Edit(jedi);
            if (result)
            {
                return Messages.EditJediOk;
            }
            throw new Exception(Messages.Error);
        }

        public IList<Jedi> GetAll()
        {
            return jediService.GetAll();
        }

        public IList<Jedi> GetByGrade(string grade)
        {
            var GradeEnum = (Grade)Enum.Parse(typeof(Grade), grade);
            return jediService.GetByFilterGrade((short)GradeEnum);
        }

        public Jedi GetById(int id)
        {
            return jediService.GetById(id);
        }
    }
}
