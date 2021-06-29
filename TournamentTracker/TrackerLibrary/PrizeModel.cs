using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Holds the place that this prize is awarded to after game end.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Holds the title of this place. e.g. Champion
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Holds the FIXED prize awarded for achieving this prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Holds what percentage of the entry fee is a reward of achieving this prize.
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
