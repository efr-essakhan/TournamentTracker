using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
/// <summary>
/// Contains executions of the Stored Procedures
/// </summary>
    public partial class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonsFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";

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

        public TeamModel CreateTeam(TeamModel model)
        {
            //Convert text file to model
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonsFile);

            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model); //add the new team to the 'teams' list (which is a list created from the text file storage)

            //Save with the new entry back to the team file
            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamFile, PersonsFile, PrizesFile);

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }


            model.Id = currentId;

            tournaments.Add(model); //add the new team to the 'tournaments' list (which is a list created from the text file storage)

            //Save with the new entry back to the team file
            tournaments.SaveToTournamentFile(TournamentFile);

        }

  

        public PersonModel CreatePerson(PersonModel model)
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


    /// <summary>
    /// For retrieving models NOT updating them.
    /// </summary>
    public partial class TextConnector : IDataConnection
    {


        public List<PersonModel> GetPerson_All()
        {
            return PersonsFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonsFile);
        }

    }

}
