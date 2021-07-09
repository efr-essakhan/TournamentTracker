using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {

        /// <summary>
        /// Holds the two entries for this matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
       /// <summary>
       /// Holds the winner of the matchup after game done.
       /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Holds the round the matchup belongs to.
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
