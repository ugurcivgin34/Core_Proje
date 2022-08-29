using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _ExperienceDal;

        public ExperienceManager(IExperienceDal ExperienceDal)
        {
            _ExperienceDal = ExperienceDal;
        }

        public void TAdd(Experience t)
        {
            _ExperienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
             _ExperienceDal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return _ExperienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _ExperienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _ExperienceDal.Update(t);
        }
    }
}
