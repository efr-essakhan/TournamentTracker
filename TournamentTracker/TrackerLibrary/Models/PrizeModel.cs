using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
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


        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberVal = 0;
            int.TryParse(placeNumber, out placeNumberVal);
            PlaceNumber = placeNumberVal;

            decimal PrizeAmountVal = 0;
            decimal.TryParse(prizeAmount, out PrizeAmountVal);
            PrizeAmount = PrizeAmountVal;

            double PrizePercentageVal = 0;
            double.TryParse(prizePercentage, out PrizePercentageVal);
            PrizePercentage = PrizePercentageVal;



        }

    }
}
