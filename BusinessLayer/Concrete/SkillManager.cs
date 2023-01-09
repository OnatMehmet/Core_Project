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
    public class SkillManager :ISkillService
    {
        ISkill _skill;

        public SkillManager(ISkill skill)
        {
            _skill = skill;
        }

        public void TAdd(Skill t)
        {
            _skill.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skill.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _skill.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _skill.GetList();
        }

        public void TUpdate(Skill t)
        {
            _skill.Update(t);
        }
    }
}
