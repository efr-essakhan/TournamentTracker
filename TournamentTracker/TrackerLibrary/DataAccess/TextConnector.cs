using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{

    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonsFile = "PersonModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file & 
            //Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;

            }

            model.Id = currentId;

            //Add new record with a new ID (max+1)
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
               
        }

        PersonModel IDataConnection.CreatePerson(PersonModel model)
        {
            List<PersonModel> persons = PersonsFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentId = 1;

            if (persons.Count > 0)
            {
                currentId = persons.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            persons.Add(model);

            persons.SaveToPersonFile(PersonsFile);

            return model;

        }
    }
}
