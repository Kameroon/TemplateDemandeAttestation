using Newtonsoft.Json;
using Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;

namespace Template.Controllers
{
    public class ValidationDemandeAttestationController : Controller
    {
        // GET: ValidationDemandeAttestation
        public ActionResult Index()
        {
            Session["Menu1"] = "Attestation De Travail";
            Session["Menu2"] = "Validation Des Demandes";

            return View();
        }
        [WebMethod]
        [ScriptMethod]
        public string GetList()
        {
            List<DemandeAttestation> List = new List<DemandeAttestation>() 
                {
                  new DemandeAttestation()   { Date= "17/05/2015", NomPrenom="Holande Chirac",Objet="Présidentielles",Statut="Refusée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "23/11/2017", NomPrenom="Nicola De Pinprenaux",Objet="Municipale",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Jean-Patrik Bouche-Trou",Objet="Réservation",Statut="Validée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Adeline Dubois",Objet="Candidature",Statut="Refusée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "18/03/2016", NomPrenom="Hassan Hasni",Objet="Achat immobilier",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest"},
                  new DemandeAttestation()   { Date= "11/12/2017", NomPrenom="Marie Dbois-Gueneck",Objet="Garde d'enfant",Statut="Validée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "18/03/2016", NomPrenom="Hassan Hasni",Objet="Achat immobilier",Statut="Refusée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "11/12/2017", NomPrenom="Marie Dbois-Gueneck",Objet="Garde d'enfant",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "17/05/2015", NomPrenom="Holande Chirac",Objet="Présidentielles",Statut="Validée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "23/11/2017", NomPrenom="Nicola De Pinprenaux",Objet="Municipale",Statut="Refusée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Jean-Patrik Bouche-Trou",Objet="Réservation",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Adeline Dubois",Objet="Candidature",Statut="Validée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Jean-Patrik Bouche-Trou",Objet="Réservation",Statut="Refusée",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                  new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Adeline Dubois",Objet="Candidature",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
            };
            return JsonConvert.SerializeObject(List.ToArray());

        }
        [WebMethod]
        [ScriptMethod]
        public string NewRequest()
        {
            List<DemandeAttestation> List = new List<DemandeAttestation>()
                {
                   new DemandeAttestation()   { Date= "23/11/2017", NomPrenom="Nicola De Pinprenaux",Objet="Municipale",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                   new DemandeAttestation()   { Date= "18/03/2016", NomPrenom="Hassan Hasni",Objet="Achat immobilier",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest"},
                   new DemandeAttestation()   { Date= "11/12/2017", NomPrenom="Marie Dbois-Gueneck",Objet="Garde d'enfant",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                   new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Jean-Patrik Bouche-Trou",Objet="Réservation",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                   new DemandeAttestation()   { Date= "08/09/2018", NomPrenom="Adeline Dubois",Objet="Candidature",Statut="En Attente",Controller="ValidationDemandeAttestation",Action="ViewRequest" },
                };
            return JsonConvert.SerializeObject(List.ToArray());

        }

        // GET: ValidationDemandeAttestation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValidationDemandeAttestation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ValidationDemandeAttestation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ValidationDemandeAttestation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ValidationDemandeAttestation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ValidationDemandeAttestation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValidationDemandeAttestation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: ValidationDemandeAttestation/AllNewRequest
        public ActionResult AllNewRequest()
        {
            return View();
        }

        // GET: ValidationDemandeAttestation/AllValidatedRequest 
        public ActionResult AllValidatedRequest()
        {
            return View();
        }

        // GET: ValidationDemandeAttestation/ViewRequest     
        public ActionResult ViewRequest()
        {
            Session["Menu1"] = "Attestation De Travail";
            Session["Menu2"] = "Détail Demande";

            return View();
        }

        // GET: ValidationDemandeAttestation/ValidatedRequest    
        public ActionResult ValidatedRequest()
        {
            return RedirectToAction("Index");
        }

        // --  Ouverture la popup de refut

    }
}
