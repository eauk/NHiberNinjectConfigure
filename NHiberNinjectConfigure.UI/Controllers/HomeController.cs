using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHiberNinjectConfigure.UI.Controllers
{
    using NHiberNinjectConfigure.Domain.Repository;

    public class HomeController : Controller
    {
        readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var posts = _repository.Posts().ToList();
            return View();
        }

    }
}
