﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface IContactService
    {
        void Add(Contact contact);
    }
}
