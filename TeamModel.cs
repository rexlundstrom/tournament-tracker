using System;
namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// a team comprised of players and a team name
        /// </summary>
        /// for some reason "System.Collections.Generic."
        /// was necessary to add in order to get the List
        /// function to work. Pretend it just says "List".
        public System.Collections.Generic.List<PersonModel> TeamMembers
        { get; set; } = new System.Collections.Generic.List<PersonModel>();
        public string TeamName { get; set; }
    }
}