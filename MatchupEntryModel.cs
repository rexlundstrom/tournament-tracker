using System;
namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// The score for this team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// The matchup this team came from as the winner
        /// </summary>
        public MatchupModel matchupModel { get; set; }
    }
}
