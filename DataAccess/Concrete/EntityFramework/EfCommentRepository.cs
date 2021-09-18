﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Repositories;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
    }
}
