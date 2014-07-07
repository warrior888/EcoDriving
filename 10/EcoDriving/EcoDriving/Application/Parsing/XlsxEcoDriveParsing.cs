﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoDriving.Application.Model;
using LinqToExcel;
using XlsParser.Model;
using XlsParser.Parsing;

namespace EcoDriving.Application.Parsing
{
    public class XlsxEcoDriveParsing : DataMaperBase<Dictionary<string, EcoDriveModel>, ExcelQueryFactory, ExcelQueryFactory>
    {
        public XlsxEcoDriveParsing(int userId)
        {
            this.userId = userId;
            // TO DO calculate drive Number somehow :) from DB 
            this.driveNum = 1;
        }

        private int userId { get; set; }      
        private int driveNum { get; set; }      

        private readonly string frameNumber = "Frame Number";
        private readonly string frameTime = "Frame Time (ms)";
        private readonly string rpm = "SAE#RPM";
        private readonly string speed = "SAE#VSS";
        private readonly string fuelConsumption = "CALC#TRIP#FUEL_USED";
        private readonly string distance = "CALC#DISTANCE";
        private readonly string currentFuelConsumption = "CALC#FC#IFC";
        private readonly string enginePower = "CALC#ENGINE_POWER";

        private readonly string workSheet = "najnowszy";

        public override Dictionary<string, EcoDriveModel> getModelData(ExcelQueryFactory queryFactory)
        {
            queryFactory.AddMapping<EcoDriveModel>(ecoDrive => ecoDrive.Id, frameNumber);
            queryFactory.AddMapping<EcoDriveModel>(ecoDrive => ecoDrive.FrameTime, frameTime);
            queryFactory.AddMapping<EcoDriveModel>(ecoDrive => ecoDrive.Rpm, rpm);
            queryFactory.AddMapping<EcoDriveModel>(ecoDrive => ecoDrive.Speed, speed);
            queryFactory.AddMapping<EcoDriveModel>(ecoDrive => ecoDrive.FuelConsumption, fuelConsumption);
            queryFactory.AddMapping<EcoDriveModel>(ecoDrive => ecoDrive.Distance, distance);
            queryFactory.AddMapping<EcoDriveModel>(ecoDrive => ecoDrive.CurrentFuelConsumption, currentFuelConsumption);
            queryFactory.AddMapping<EcoDriveModel>(ecoDrive => ecoDrive.EnginePower, enginePower);

            var drive = queryFactory.Worksheet<EcoDriveModel>(workSheet).Select(x => (EcoDriveModel)x);
            var resoult = new Dictionary<string, EcoDriveModel>();

            int i = 1;
            foreach (EcoDriveModel item in drive)
            {
                if (item.Id == 0)
                {
                    resoult.Add(string.Format("{0}{1}", item.Id, i++), item);
                    continue;
                }

                item.UserId = userId;
                item.DriveNum = driveNum;

                resoult.Add(item.Id.ToString(), item);
                item.SaveData();
            }

            return resoult;
        }

        public override Dictionary<string, EcoDriveModel> getAdequateParser(ExcelQueryFactory queryFactory)
        {
            return null;
        }
    }
}