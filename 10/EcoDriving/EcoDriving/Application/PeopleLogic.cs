using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoDriving.Application.Model;
using EcoDriving.Models;

namespace EcoDriving.Application
{
    public class PeopleLogic
    {
        public void SavePerson(PeopleViewModel model)
        {
            PeopleModel dbModel = new PeopleModel();

            if (model.Id > 0)
            {
                dbModel.Id = model.Id;
            }

            dbModel.Name = model.Name;
            dbModel.Surname = model.Surname;

            dbModel.SaveData();
        }

        public List<PeopleModel> GetPeopleData(string name, string surname)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "%";
            }

            if (string.IsNullOrEmpty(surname))
            {
                surname = "%";
            }

            PeopleModel model = new PeopleModel();
            string sqlQueryCommand = string.Format("select * from {0} where {1} like '{2}' and {3} like '{4}';", model.TableName, PeopleModel.nameColumn, name, PeopleModel.surnameColumn, surname);

            return model.GetData(sqlQueryCommand);
        }

        public List<PeopleModel> GetPerson(int id)
        {
            PeopleModel model = new PeopleModel();
            string sqlQueryCommand = string.Format("select * from {0} where {1} = '{2}';", model.TableName, PeopleModel.idColumn, id);

            return model.GetData(sqlQueryCommand);
        }
    }
}