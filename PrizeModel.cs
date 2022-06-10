using System;
namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// an integer for final placement
        /// 1 = 1st place; 2 = 2nd place, etc
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// a verbal represention of final placement
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// stable cash prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// prize as a percentage of "the pot"
        /// this prize amount is variable based
        /// on total aggregated entry fees
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
