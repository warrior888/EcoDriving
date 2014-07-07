using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GhostRider.DatabaseAccess.DAL;
using GhostRider.DatabaseAccess.Model;

namespace ParseAndSaveData
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleModel human = new PeopleModel();
          //  human.Id = 1;
            human.Name = "Domi";

            human.SaveData();
            human.SaveData();
            human.SaveData();

            human.Name = "chmura";

            human.SaveData();
            human.SaveData();

            var dupa = 3;
        }
    }
}
