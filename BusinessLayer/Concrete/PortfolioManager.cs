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
    
    public class PortfolioManager : IGenericService<Portfolio>
    {
        IPortfolio _portfolio;

        public PortfolioManager(IPortfolio portfolio)
        {
            _portfolio = portfolio;
        }

        public void TAdd(Portfolio t)
        {
            _portfolio.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolio.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolio.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolio.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _portfolio.Update(t);
        }
    }
}
