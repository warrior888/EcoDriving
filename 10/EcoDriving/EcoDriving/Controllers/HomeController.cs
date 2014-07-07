using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcoDriving.Application;
using EcoDriving.Application.Model;
using EcoDriving.Models;

namespace EcoDriving.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Charts(PeopleViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Draw))
            {
                EcoDriveModel ecoModel = new EcoDriveModel();
                var results =
                    ecoModel.GetData(string.Format("select * from EcoDriving where userId = 1 and driveNum =1"));
                    //driver i drive tutaj na sztywno lecz zakladam ze sa juz wybrane globalnie na poczatku
                model.EcoDrivingData = results;
            }
            return View(model);
        }
        



        public ActionResult People(PeopleViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Search))
            {
                PeopleLogic logic = new PeopleLogic();
                var result = logic.GetPeopleData(model.Name, model.Surname);

                model.SearchResults = result;
            }

            if (!string.IsNullOrEmpty(model.Confirm))
            {
                // db save operation
                PeopleLogic logic = new PeopleLogic();
                logic.SavePerson(model);
            }

            return View(model);
        }

        public ActionResult PeopleChoose(PeopleViewModel model)
        {
            // odebranie pliku
            // wrzucenie pliku do bd
            // na stronie widoku dodanie przycisku do amchartow
            // generuj wykres
            if (!string.IsNullOrEmpty(model.Confirm))
            {
                // sciezka do pliku bedzie przeslana do rideFile z people model
                string path = "D:\\praca\\nowy potencjal\\szkolenie\\Dropbox\\Szkolenie\\level 3\\10\\najnowszy.xlsx";
                DataMapperLogic logic = new DataMapperLogic();
                var result = logic.GetParsedData(path, model.Id);
            }

            if (!string.IsNullOrEmpty(model.ShowGraph))
            {
                EcoDriveModel ecoModel = new EcoDriveModel();
                var results = ecoModel.GetData(string.Format("select * from EcoDriving where userId = {0}", model.Id)); // and drive number = ...

                model.EcoDrivingData = results;
            }

            return View(model);
        }
    }
}
