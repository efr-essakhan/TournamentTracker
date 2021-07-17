using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using Dapper;
using System.Data.SqlClient;

namespace TrackerLibrary.DataAccess
{/// <summary>
/// Contains executions of the Stored Procedures
/// </summary>
    public class SqlConnector : IDataConnection
    {

        private const string db = "TrackerDB";

        /// <summary>
        /// Saves a new Prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The pirze information, including the Unique id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output); //take back information.

                connection.Execute("dbo.spPrize_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id"); // set the taken back information.

                return model;
            
            }   

        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.Email);
                p.Add("CellphoneNumber", model.CellphoneNumber);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPerson_GetAll").ToList();
            }

            return output;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@TeamName", model.TeamName);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeam_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                foreach (PersonModel teamMember in model.TeamMembers)
                {

                    p = new DynamicParameters();

                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", teamMember.Id);

                    connection.Execute("dbo.spTeamMember_Insert", p, commandType: CommandType.StoredProcedure);

                }

                return model;
            }
        }


        public TournamentModel CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {

            }
        }

        public List<TeamModel> GetTeam_All()
        {
            //Connect into db and retrieve team.

            List<TeamModel> teams;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                //Get team ID and Name.
                
                teams = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                //Get the team members indivirually using sql and setting them.
                foreach (TeamModel team in teams)
                {

                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMember_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }


            }

            return teams;

        }

    }
}
