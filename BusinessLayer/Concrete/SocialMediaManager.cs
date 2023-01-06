﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : IGenericService<SocialMedia>
    {
        ISocialMedia _socialMedia;

        public SocialMediaManager(ISocialMedia socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMedia.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMedia.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
           return _socialMedia.GetByID(id); 
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMedia.GetList();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMedia.Update(t);
        }
    }
}
