using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcNHibernate.Models
{
    public class Categories
    {
        public virtual int Id { get; protected set; }
        public virtual string CategoryName { get; set; }
        public virtual IList<Products> Products { get; protected set; }

        public Categories()
        {
            Products = new List<Products>();
        }
    }

}