using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcoDriving.Application;
using EcoDriving.Application.Model;
using EcoDriving.Models;
using Microsoft.Ajax.Utilities;
using WebGrease.Css;

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

        public ActionResult SelectedDrive(int id, int driveNum)
        {
            PeopleViewModel model = new PeopleViewModel();
            model.Id = id;
            model.DriveNumber = driveNum;

            return RedirectToAction("Charts","Home",model);
        }

        public ActionResult Charts(PeopleViewModel xModel)
        {

            PeopleViewModel model = new PeopleViewModel();
            model.Id = xModel.Id;
            model.DriveNumber = xModel.DriveNumber;
            model.Analyze = "go";
            return View(model);
        }

        public ActionResult CoursantList()
        {

            PeopleLogic logic = new PeopleLogic();
            var result = logic.GetPeopleData("", "");


            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(
                            result,
                            "Id",
                            "FullName"), JsonRequestBehavior.AllowGet
                            );
            }

            return RedirectToAction("Charts");
        }

        public ActionResult DriveList(int id)
        {

            EcoDriveModel ecoModel = new EcoDriveModel();
            List<EcoDriveModel> results =
                ecoModel.GetData(string.Format("select driveNum from EcoDriving where userId = {0} group by driveNum order by driveNum;", id), new [] { "driveNum" });

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(
                    results,
                    "driveNum",
                    "driveNum"), JsonRequestBehavior.AllowGet
                    );
            }

            return RedirectToAction("Charts");
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
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];

                    string path = "C:\\temp\\" + file.FileName; 

                    if (file != null && file.ContentLength > 0)
                    {
                        //var fileName = Path.GetFileName(file.FileName);
                        //path += fileName;
                        //path = "C:\\Programowanie\\level 3\\10\\najnowszy.xlsx";
                        file.SaveAs(path);

                        EcoDriveModel ecoModel = new EcoDriveModel();
                        List<EcoDriveModel> results =
                            ecoModel.GetData(string.Format("select * from EcoDriving where userId = {0}", model.Id));
                        // and drive number = ...
                        int driveNumber = 0;
                        foreach (var item in results)
                        {
                            if (item.DriveNum >= driveNumber)
                                driveNumber = item.DriveNum;
                        }
                        driveNumber += 1;
                        model.DriveNumber = driveNumber;

                        DataMapperLogic logic = new DataMapperLogic();
                        var result = logic.GetParsedData(path, model.Id, driveNumber);
                        model.FileLabel = "Pomyślnie dodano przejazd do bazy.";
                    }
                    else
                    {
                        model.FileLabel = "Błąd - wybierz plik";
                    }
                }
                else
                {
                    model.FileLabel = "Błąd - wybierz plik";
                }
            }

            if (!string.IsNullOrEmpty(model.ShowGraph))
            {
                EcoDriveModel ecoModel = new EcoDriveModel();
                var results = ecoModel.GetData(string.Format("select * from EcoDriving where userId = {0} and driveNum = {1};", model.Id, model.DriveNumber)); // and drive number = ...

                model.EcoDrivingData = results;
            }

            PeopleLogic person = new PeopleLogic();
            var resultPerson = person.GetPerson(model.Id);

            model.Name = resultPerson[0].Name;
            model.Surname = resultPerson[0].Surname;

            

            return View(model);
        }
    }
}
