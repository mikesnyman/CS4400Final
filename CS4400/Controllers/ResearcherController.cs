using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS4400.Controllers
{
    public class ResearcherController : Controller
    {
        public ActionResult Index()
        {
            /*
            using (var uow = new CS4400.Data.UnitOfWork())
            {
                var studies = uow.Studies.GetAll();
                return View(studies);
            }
            */
            return View();
        }
        
        public ActionResult Question()
        {
            /*
            using (var uow = new CS4400.Data.UnitOfWork())
            {
                var studies = uow.Studies.GetAll();
                return View(studies);
            }
            */
            return View();
        }

        public ActionResult Add()
        {
            var vm = new CS4400.Model.Study();
            vm.Id = Guid.NewGuid();
            vm.ResearcherId = Guid.NewGuid();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Add(CS4400.Model.Study vm)
        {
            /*
            using (var uow = new CS4400.Data.UnitOfWork())
            {
                uow.Studies.Add(vm);
                uow.Commit();
            }
            */
            throw new NotImplementedException();
        }

        public ActionResult Edit(Guid id)
        {
            /*
            using (var uow = new CS4400.Data.UnitOfWork())
            {
                var study = uow.Studies.Find(id);
                return View(study);
            }
            */
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Edit(CS4400.Model.Study vm)
        {
            /*
            using (var uow = new CS4400.Data.UnitOfWork())
            {
                uow.Studies.Update(vm);
                uow.Commit();
            }
            */
            throw new NotImplementedException();
        }

        public ActionResult FilterCharacteristics()
        {
            return View();
        }
    }
}
