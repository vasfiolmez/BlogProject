﻿using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.Abstract
{
    public interface IArticleDal:IGenericDal<Article>
    {
    }
}
