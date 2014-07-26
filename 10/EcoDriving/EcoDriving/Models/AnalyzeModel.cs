using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EcoDriving.Application.Model;

namespace EcoDriving.Models
{
    public class AnalyzeModel
    {
        public int IdPerson { get; set; }

        public int DriveNumber { get; set; }

        public string Analyze { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int DriveTimeMinute { get; set; }

        public int DriveTimeSeconds { get; set; }

        public float DriveDistance { get; set; }

        public float TimeOfStop { get; set; }

        public int NumberOfStops { get; set; }

        public int MaxRpm { get; set; }

        public int MaxSpeed { get; set; }

        public int MaxPower { get; set; }

        public double TotalRpm { get; set; }

        public long TotalPower { get; set; }

        public double FuelUsed { get; set; }

        public double AverageFuel { get; set; }

        public double AveragePower { get; set; }

        public double AverageSpeed { get; set; }

        public double AverageRpm { get; set; }

        public List<EcoDriveModel> EcoDrivingData { get; set; }

        public PeopleModel Person { get; set; }


        public int IdPerson2 { get; set; }

        public int DriveNumber2 { get; set; }

        public string Analyze2 { get; set; }

        public string Name2 { get; set; }

        public string Surname2 { get; set; }

        public int DriveTimeMinute2 { get; set; }

        public int DriveTimeSeconds2 { get; set; }

        public float DriveDistance2 { get; set; }

        public float TimeOfStop2 { get; set; }

        public int NumberOfStops2 { get; set; }

        public int MaxRpm2 { get; set; }

        public int MaxSpeed2 { get; set; }

        public int MaxPower2 { get; set; }

        public double TotalRpm2 { get; set; }

        public long TotalPower2 { get; set; }

        public double FuelUsed2 { get; set; }

        public double AverageFuel2 { get; set; }

        public double AveragePower2 { get; set; }

        public double AverageSpeed2 { get; set; }

        public double AverageRpm2 { get; set; }

        public List<EcoDriveModel> EcoDrivingData2 { get; set; }

        public PeopleModel Person2 { get; set; }
    }
}