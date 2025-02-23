using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        public int CategoryDescription { get; set; }
        public bool Status { get; set; }
    }
}
