using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcoDriving.Application;
using EcoDriving.Application.Model;
using EcoDriving.Models;
using Microsoft.Ajax.Utilities;

namespace EcoDriving.Controllers
{
    public class AnalyzeController : Controller
    {
        
        // GET: /Analyze/

        public ActionResult SingleAnalyze(int id, int driveNum)
        {
            AnalyzeModel model = new AnalyzeModel();
            model.IdPerson = id;
            model.DriveNumber = driveNum;

            if (model.EcoDrivingData == null)
            {
                Analyze resoults = new Analyze(model);
                model = resoults.MakeComputations();

            }

            return View(model);
        }

        public ActionResult DoubleAnalyze(int id, int driveNum, int id2, int driveNum2)
        {
            AnalyzeModel model = new AnalyzeModel();
            model.IdPerson = id;
            model.DriveNumber = driveNum;
            model.IdPerson2 = id2;
            model.DriveNumber2 = driveNum2;

            if (model.EcoDrivingData == null)
            {
                Analyze resoults = new Analyze(model);
                model = resoults.MakeComputations();

                AnalyzeModel model2 = new AnalyzeModel();
                model2.IdPerson = id2;
                model2.DriveNumber = driveNum2;
                resoults = new Analyze(model2);
                model2 = resoults.MakeComputations();

                model.Name2 = model2.Name;
                model.Surname2 = model2.Surname;
                model.DriveTimeMinute2 = model2.DriveTimeMinute;
                model.DriveTimeSeconds2 = model2.DriveTimeSeconds;
                model.DriveDistance2 = model2.DriveDistance;
                model.TimeOfStop2 = model2.TimeOfStop;
                model.NumberOfStops2 = model2.NumberOfStops;
                model.MaxRpm2 = model2.MaxRpm;
                model.MaxSpeed2 = model2.MaxSpeed;
                model.MaxPower2 = model2.MaxPower;
                model.TotalRpm2 = model2.TotalRpm;
                model.TotalPower2 = model2.TotalPower;
                model.FuelUsed2 = model2.FuelUsed;
                model.AverageFuel2 = model2.AverageFuel;
                model.AveragePower2 = model2.AveragePower;
                model.AverageSpeed2 = model2.AverageSpeed;
                model.AverageRpm2 = model2.AverageRpm;
                model.EcoDrivingData2 = model2.EcoDrivingData;
                model.Person2 = model2.Person;

                
            }

            return View(model);
        }


    }
}
