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
    public class AboutManager : IGenericService<About>
    {
        IAbout _about;

        public AboutManager(IAbout about)
        {
            _about = about;
        }

        public void TAdd(About t)
        {
            _about.Insert(t);
            

        }

        public void TDelete(About t)
        {
           _about.Delete(t);
        }

        public About TGetByID(int id)
        {
           return _about.GetByID(id);
        }

        public List<About> TGetList()
        {
           return _about.GetList();

        }

        public void TUpdate(About t)
        {
            _about.Update(t);
        }
    }
}
