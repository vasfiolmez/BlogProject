using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Concrete
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CoverImage { get; set; }
        public string MainImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }

    }
}
