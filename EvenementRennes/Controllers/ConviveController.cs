using EvenementRennes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualBasic.FileIO;
using WebGrease.Css.Ast.Selectors;
using WebGrease.Css.Extensions;
using FieldType = Microsoft.Ajax.Utilities.FieldType;

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
            listE.Add(new Evenement(Guid.NewGuid(), "Parc du Thabor", new DateTime(), new TimeSpan(), "a", "b", listeI));
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
            Console.WriteLine("inside");
            Console.WriteLine("adresse: "+ collection.Get("adresse"));
            Console.WriteLine("lieu: "+ collection.Get("lieu"));
            Console.WriteLine("duree: "+ collection.Get("duree"));
            ViewData["adresse"] =  collection.Get("adresse");
            ViewData["lieu"] = collection.Get("lieu");
            ViewData["duree"] =  collection.Get("duree");

            
            /*WebRequest request = WebRequest.Create ("http://data.citedia.com/r1/parks/timetable-and-prices");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse ();
            Stream dataStream = response.GetResponseStream ();
            StreamReader reader = new StreamReader (dataStream);
            string responseFromServer = reader.ReadToEnd ();
            
            Console.WriteLine (responseFromServer);
            reader.Close ();
            dataStream.Close ();
            response.Close ();*/


//            Console.WriteLine(" test: "+System.IO.File.ReadAllLines(responseFromServer).Skip(1));
              /*  select new
                {
                    

                    Plant = columns[0],
                    Material = int.Parse(columns[1]),
                    Density = float.Parse(columns[2]),
                    StorageLocation = int.Parse(columns[3])

                }*/
            
            /*var allTextLines = responseFromServer.Split('\n');
            allTextLines.ForEach((lines) =>
            {
                Console.WriteLine("lines: "+lines);
                var separatesDatas = lines.Split(';');
                separatesDatas.ForEach((data) =>
                {
                    Console.WriteLine("separatesDatas: " + data);
                });
            });*/
             
            
            /*TextFieldParser parser = new TextFieldParser(responseFromServer);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData) 
            {
                //Processing row
                string[] fields = parser.ReadFields();
                foreach (string field in fields) 
                {
                    //TODO: Process field
                }
            }*/
            
            /*using (TextFieldParser parser = new TextFieldParser(@"c:\temp\test.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData) 
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields) 
                    {
                        //TODO: Process field
                    }
                }
            }            */

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