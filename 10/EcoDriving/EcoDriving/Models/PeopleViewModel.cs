using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EcoDriving.Application.Model;

namespace EcoDriving.Models
{
    public class PeopleViewModel
    {
        public int Id { get; set; }

        public int DriveNumber { get; set; }

        [Display(Name = "UserName", ResourceType = typeof(Resources.Translations))]
        public string Name { get; set; }

        [Display(Name = "UserSurname", ResourceType = typeof(Resources.Translations))]
        public string Surname { get; set; }

        public string Confirm { get; set; } // save new to db

        public string Search { get; set; } // search for people

        public string RideFile { get; set; }

        public string ShowGraph { get; set; }

        public string Draw { get; set; }

        public string Date { get; set; }

        public string Description { get; set; }

        public string Analyze { get; set; }

        [Display(Name = "FileLabel", ResourceType = typeof(Resources.Translations))]
        public string FileLabel { get; set; }

        public List<PeopleModel> SearchResults { get; set; }

        public List<EcoDriveModel> EcoDrivingData { get; set; }
    }
}