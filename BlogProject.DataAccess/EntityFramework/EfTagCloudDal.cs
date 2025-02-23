using BlogProject.DataAccess.Abstract;
using BlogProject.DataAccess.Context;
using BlogProject.DataAccess.Repositories;
using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.EntityFramework
{
    public class EfTagCloudDal : GenericRepository<TagCloud>, ITagCloudDal
    {
        public EfTagCloudDal(BlogContext context) : base(context)
        {
        }
    }
}
