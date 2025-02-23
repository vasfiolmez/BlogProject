using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Concrete
{
    public class About
    {
        public int AboutId { get; set; }
        public string AboutDetail1 { get; set; }
        public string AboutDetail2 { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
        public string AboutMapLocation { get; set; }
        public bool Status { get; set; }
    }
}
