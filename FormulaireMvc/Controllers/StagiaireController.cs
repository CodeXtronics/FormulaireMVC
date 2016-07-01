using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormulaireBo;
using FormulaireBll;

namespace FormulaireMvc.Controllers
{
    public class StagiaireController : Controller
    {
        GestionnaireFormulaire ctl = new GestionnaireFormulaire();
        static Stagiaire LeStagiaire = new Stagiaire();
        public ActionResult Formulaire()
        {
            return View(LeStagiaire);
        }
        // GET: /Stagiaire/Create
        public ActionResult Create()
        {
            // charger les Qualification
            ICollection<Qualification> lstQualifications = ctl.ChargerLesQualifications();
            TempData["lstQualifications"] = lstQualifications;
            ViewBag.lstQualifications = new SelectList(lstQualifications, "Id", "LibelleQualification");
            // charger les Sexe
            ICollection<Sexe> lstSexes = ctl.ChargerLesSexes();
            TempData["lstSexes"] = lstSexes;
            ViewBag.lstSexes = new SelectList(lstSexes, "Id", "Type");
            return View();
        }
        public ActionResult Merci(Stagiaire s)
        {
            return View(s);
        }

        // POST: /Stagiaire/Create
        //[AcceptVerbs(HttpVerbs.Post)]
        [HttpPost]
        public ActionResult Create(Stagiaire stagi)
        {
            if (ModelState.IsValid)
            {
                ctl.CreerStagiaire(stagi);
                return View("Merci", stagi);
            }

            

            return RedirectToAction("Create");
        }
    }
}