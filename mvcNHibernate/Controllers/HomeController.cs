using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using mvcNHibernate.Models;
using mvcNHibernate.Repositories;

namespace mvcNHibernate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Categories> catRepository;

        // Constructs our home controller
        public HomeController()
        {
            catRepository = new Repository<Categories>();
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var categories = catRepository.GetAll();

            return View(categories.ToList());
        }

    }
}
