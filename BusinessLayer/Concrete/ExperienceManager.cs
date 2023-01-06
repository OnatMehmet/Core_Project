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
    public class ExperienceManager : IGenericService<Experience>
    {
        IExperience _experience;

        public ExperienceManager(IExperience experience)
        {
            _experience = experience;
        }

        public void TAdd(Experience t)
        {
            _experience.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experience.Delete (t);
        }

        public Experience TGetByID(int id)
        {
           return _experience.GetByID (id);
        }

        public List<Experience> TGetList()
        {
            return _experience.GetList();
        }

        public void TUpdate(Experience t)
        {
            _experience.Update(t);
        }
    }
}
