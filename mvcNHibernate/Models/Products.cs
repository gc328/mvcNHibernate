﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcNHibernate.Models
{
    public class Products
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Price { get; set; }

    }
}