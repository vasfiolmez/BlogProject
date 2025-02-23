using BlogProject.DataAccess.Abstract;
using BlogProject.DataAccess.Context;
using BlogProject.DataAccess.Repositories;
using MyBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(BlogContext context) : base(context)
        {

        }
    }
}
