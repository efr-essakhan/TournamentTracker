using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {

        //Create our matchups 
        // Order our list randomly of teams
        // Check if list is big enough - if not add in byes: automatic win
        // For a tournament to work it needs to be one of 2 squared numbers 2^n teams
        // Create first round of matchups
        // Create every round after that. 8 teams: 4 matchups = 2 matchups - 1 matchups (divide by 2)
        
        public static void CreateRounds(TournamentModel model)
        {

            // Order our list randomly of teams
            List<TeamModel> rondomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(rondomizedTeams.Count);
            int byes = NumberOfByes(rounds, rondomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, rondomizedTeams));

            CreateOtherRounds(model, rounds);

        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {

        }


        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();


            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }

            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i < rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output += 1;
                val *= 2;
            }

            return output;


        }



        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }


    }
}
