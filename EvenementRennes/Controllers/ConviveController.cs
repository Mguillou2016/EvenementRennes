using EvenementRennes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvenementRennes.Controllers
{
    public class ConviveController : Controller
    {
        public string adresse = "test";
        List<Evenement> listE = new List<Evenement>();
        List<string> listeI = new List<string>();

        public ConviveController()
        {
            listeI.Add("test");
            listE.Add(new Evenement(Guid.NewGuid(), "rennes", new DateTime(), new TimeSpan(), "a", "Mox dicta finierat, multitudo omnis ad, quae imperator voluit, promptior laudato consilio consensit in pacem ea ratione maxime percita, quod norat expeditionibus crebris fortunam eius in malis tantum civilibus vigilasse, cum autem bella moverentur externa, accidisse plerumque luctuosa, icto post haec foedere gentium ritu perfectaque sollemnitate imperator Mediolanum ad hiberna discessit.", listeI));
            listE.Add(new Evenement(Guid.NewGuid(), "rennes", new DateTime(), new TimeSpan(), "a", "b", listeI));
            listE.Add(new Evenement(Guid.NewGuid(), "rennes", new DateTime(), new TimeSpan(), "a", "b", listeI));
            listE.Add(new Evenement(Guid.NewGuid(), "rennes", new DateTime(), new TimeSpan(), "a", "b", listeI));

            listE.Add(new Evenement(Guid.NewGuid(), "rennes", new DateTime(), new TimeSpan(), "a", "b", listeI));

            listE.Add(new Evenement(Guid.NewGuid(), "rennes", new DateTime(), new TimeSpan(), "a", "b", listeI));

            listE.Add(new Evenement(Guid.NewGuid(), "rennes", new DateTime(), new TimeSpan(), "a", "b", listeI));

            listE.Add(new Evenement(Guid.NewGuid(), "rennes", new DateTime(), new TimeSpan(), "a", "b", listeI));


        }
        // GET: Convive
        public ActionResult IndexConvive()
        {
            ViewBag.Adresse = adresse;
            return View(listE);
        }
        // POST: Convive
        [HttpPost]
        public ActionResult IndexConvive(FormCollection collection)
        {
            ViewBag.adresse = collection.Get("Adresse");
            //string adresse = collection.Get("Adresse");
            //Debug.WriteLine("adresse", adresse);
            return View(listE);
        }
        [HttpPost]
        public ActionResult TrajetConvive(FormCollection collection)
        {
            Debug.WriteLine("inside");
            Debug.WriteLine("adresse", collection.Get("adresse"));
            ViewData["adresse"] =  collection.Get("adresse");

            /*foreach(string element in collection)
            {
                Debug.WriteLine("test", element);
            }*/
            return View("trajetConvive");
        }
        [Route("convive/someAction")]
        public ActionResult SomeAction()
        {
            return Json(new { SomeValue = "foo bar" }, JsonRequestBehavior.AllowGet);
        }
    }
}