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
    public class EfCommentDal:GenericRepository<Comment>,ICommentDal
    {
        private readonly BlogContext _context;
        public EfCommentDal(BlogContext context) : base(context)
        {
            _context = context;
        }
    }
}
