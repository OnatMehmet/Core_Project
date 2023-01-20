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
    public class FeatureManager :IFeatureService
    {
        IFeatureDal _feature;
        public FeatureManager(IFeatureDal feature)
        {
            _feature = feature;
        }

        public void TAdd(Feature t)
        {
            _feature.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _feature.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _feature.GetByID(id);
        }

        public List<Feature> TGetList()
        {
            return _feature.GetList();
        }

        public void TUpdate(Feature t)
        {
            _feature.Update(t);
        }
    }
}
