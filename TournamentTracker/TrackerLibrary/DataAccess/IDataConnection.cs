using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    /// <summary>
    /// Methods to execute stored proceduures depending on the DB type used.
    /// </summary>
    public interface IDataConnection
    {

        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);

        TeamModel CreateTeam(TeamModel model);

        void CreateTournament(TournamentModel model);

        List<PersonModel> GetPerson_All();

        List<TeamModel> GetTeam_All();


    }
}
