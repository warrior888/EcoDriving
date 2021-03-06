﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using GhostRider.DatabaseAccess.DAL;
using GhostRider.DatabaseAccess.DAL.Fields;
using Npgsql;

namespace EcoDriving.Application.Model
{
    public class EcoDriveModel : DbTable<EcoDriveModel, DbField>
    {

        protected override string tableName
        {
            get { return "EcoDriving"; }
        }

        public const string idColumn = "frameNumber";
        public const string frameTimeColumn = "frameTime";
        public const string frameTimeDeltaColumn = "frameTimeDelta";
        public const string rpmColumn = "rpm";
        public const string speedColumn = "speed";
        public const string fuelConsumptionColumn = "fuelConsumption";
        public const string distanceColumn = "distance";
        public const string currentFuelConsumptionColumn = "currentFuelConsumption";
        public const string enginePowerColumn = "enginePower";
        public const string userIdColumn = "userId";
        public const string driveNumColumn = "driveNum";

        public int UserId
        {
            get { return (int)this.dataBaseTable[userIdColumn].FieldValue; }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(userIdColumn, value, new DbInsertField());
            }
        }

        public int Id
        {
            get { return (int)this.dataBaseTable[idColumn].FieldValue; }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(idColumn, value, new DbInsertField());
            }
        }

        public int DriveNum
        {
            get { return (int)this.dataBaseTable[driveNumColumn].FieldValue; }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(driveNumColumn, value, new DbInsertField());
            }
        }

        public string FrameTime
        {
            get { return this.dataBaseTable[frameTimeColumn].FieldValue.ToString(); }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(frameTimeColumn, value, new DbInsertField());
            }
        }

        public string FrameTimeDelta
        {
            get { return this.dataBaseTable[frameTimeDeltaColumn].FieldValue.ToString(); }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(frameTimeDeltaColumn, value, new DbInsertField());
            }
        }

        public int Rpm
        {
            get
            {
                return (int)this.dataBaseTable[rpmColumn].FieldValue;
            }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(rpmColumn, value, new DbInsertField());
            }
        }

        public int Speed
        {
            get { return (int)this.dataBaseTable[speedColumn].FieldValue; }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(speedColumn, value, new DbInsertField());
            }
        }

        public string FuelConsumption
        {
            get { return this.dataBaseTable[fuelConsumptionColumn].FieldValue.ToString(); }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(fuelConsumptionColumn, value, new DbInsertField());
            }
        }

        public float  Distance
        {
            get { return (float)this.dataBaseTable[distanceColumn].FieldValue; }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(distanceColumn, value, new DbInsertField());
            }
        }

        public string CurrentFuelConsumption
        {
            get { return this.dataBaseTable[currentFuelConsumptionColumn].FieldValue.ToString(); }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(currentFuelConsumptionColumn, value, new DbInsertField());
            }
        }

        public int EnginePower
        {
            get { return (int)this.dataBaseTable[enginePowerColumn].FieldValue; }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(enginePowerColumn, value, new DbInsertField());
            }
        }

        protected override EcoDriveModel readRow(NpgsqlDataReader reader, string[] columns = null)
        {
            var result = new EcoDriveModel();

            if (columns != null)
            {
                result.Id = columns.Contains(idColumn) ? (int)reader[idColumn] : 0;
                result.FrameTime = columns.Contains(frameTimeColumn) ? reader[frameTimeColumn].ToString() : string.Empty;
                result.FrameTimeDelta = columns.Contains(frameTimeDeltaColumn) ? reader[frameTimeDeltaColumn].ToString() : string.Empty;
                // todo zrobic
//                result.Rpm = (int)reader[rpmColumn];
//                result.Speed = (int)reader[speedColumn];
//                result.FuelConsumption = reader[fuelConsumptionColumn].ToString();
//                result.Distance = float.Parse(reader[distanceColumn].ToString(),
//                    System.Globalization.CultureInfo.InvariantCulture);
//                result.CurrentFuelConsumption = reader[currentFuelConsumptionColumn].ToString();
//                result.EnginePower = (int)reader[enginePowerColumn];
                result.DriveNum = columns.Contains(driveNumColumn) ? (int)reader[driveNumColumn] : 0;
//                result.UserId = (int)reader[userIdColumn];
            }
            else
            {
                result.Id = (int) reader[idColumn];
                result.FrameTime = reader[frameTimeColumn].ToString();
                result.FrameTimeDelta = reader[frameTimeDeltaColumn].ToString();
                result.Rpm = (int) reader[rpmColumn];
                result.Speed = (int) reader[speedColumn];
                result.FuelConsumption = reader[fuelConsumptionColumn].ToString();
                //result.Distance = (float)reader.GetFloat(distaceColumnId); // SPRAWDZIC BO MOZE GENEROWAC ERROR
                if (!string.IsNullOrEmpty(reader[distanceColumn].ToString()))
                {
                    result.Distance = float.Parse(reader[distanceColumn].ToString(), 
                        System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    result.Distance = 0;
                }

                result.CurrentFuelConsumption = reader[currentFuelConsumptionColumn].ToString();
                result.EnginePower = (int) reader[enginePowerColumn];
                result.DriveNum = (int) reader[driveNumColumn];
                result.UserId = (int) reader[userIdColumn];
            }
            return result;
        }
    }
}