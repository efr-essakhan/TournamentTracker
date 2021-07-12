using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using Dapper;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new Prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The pirze information, including the Unique id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("TrackerDB")))
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
    }
}
