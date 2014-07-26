﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoDriving.Application.Model;
using EcoDriving.Models;

namespace EcoDriving.Application
{
    public class Analyze
    {
        private AnalyzeModel model;

        public Analyze(AnalyzeModel model)
        {
            this.model = model;
        }

        public AnalyzeModel MakeComputations()
        {
            EcoDriveModel ecoModel = new EcoDriveModel();
                List<EcoDriveModel> results =
                ecoModel.GetData(string.Format("select * from EcoDriving where userId = {0} and driveNum = {1};", model.IdPerson, model.DriveNumber));
                model.EcoDrivingData = results;

                PeopleLogic person = new PeopleLogic();
                var resultPerson = person.GetPerson(model.IdPerson);

                model.Name = resultPerson[0].Name;
                model.Surname = resultPerson[0].Surname;

                model.DriveDistance = model.EcoDrivingData[model.EcoDrivingData.Count - 1].Distance;
                int seconds = int.Parse(model.EcoDrivingData[model.EcoDrivingData.Count - 1].FrameTime) / 1000;
                int minutes = seconds/60;
                seconds -= minutes*60;
                model.DriveTimeMinute = minutes;
                model.DriveTimeSeconds = seconds;

                int timeOnStop = 0;
                int numberOfStops = 0;
                bool flag = false;
                model.MaxPower = 0;
                model.MaxRpm = 0;
                model.MaxSpeed = 0;
                model.TotalRpm = 0;
                model.TotalPower = 0;
                foreach (var item in model.EcoDrivingData)
                {
                    model.TotalRpm += item.Rpm * (int.Parse(item.FrameTimeDelta) / 60000.0);
                    model.TotalPower += item.EnginePower;
                    if (item.EnginePower > model.MaxPower)
                    {
                        model.MaxPower = item.EnginePower;
                    }

                    if (item.Rpm > model.MaxRpm)
                    {
                        model.MaxRpm = item.Rpm;
                    }

                    if (item.Speed > model.MaxSpeed)
                    {
                        model.MaxSpeed = item.Speed;
                    }

                    if (item.Speed == 0)
                    {
                        timeOnStop += int.Parse(item.FrameTimeDelta);
                        if (flag==false)
                        {
                            numberOfStops++;
                            flag = true;
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
                model.TimeOfStop = timeOnStop / (float)1000;
                model.NumberOfStops = numberOfStops;

                string temp = model.EcoDrivingData[model.EcoDrivingData.Count - 1].FuelConsumption;
                string temp2 = temp.Split(',').Last();
                model.FuelUsed = (Math.Round(double.Parse(temp2) * 378.5411784)) / 100.0;

                model.TotalRpm = (Math.Round(model.TotalRpm * 100) / 100);
                model.AverageSpeed = (Math.Round((model.DriveDistance / ((seconds + (minutes * 60)) / 3600.0)) * 100)) / 100;

                model.AverageRpm = (Math.Round((model.TotalRpm / (minutes + seconds / 60.0)) * 100)) / 100;

                model.AveragePower = (Math.Round((model.TotalPower / (double)model.EcoDrivingData.Count) * 100)) / 100;

                model.AverageFuel = (Math.Round((100 * model.FuelUsed / model.DriveDistance) * 100)) / 100;

            return model;
        }
    }
}