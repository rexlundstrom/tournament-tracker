using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// name of tourney
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// cost of tourney
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// a list of teams in this tourney
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// represents a fixed or variable prize amount
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// represents all of the rounds in this tourney
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
