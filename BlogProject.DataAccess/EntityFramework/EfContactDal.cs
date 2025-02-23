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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        private readonly BlogContext _context;
        public EfContactDal(BlogContext context) : base(context)
        {
            _context = context;
        }
    }
}
