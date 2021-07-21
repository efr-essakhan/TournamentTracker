using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {

        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();

                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lines"></param> called on LoadFile(), which returns a List<String>, each line is a line from the TextFile
        /// <param name="personsFileName"></param>
        /// <returns></returns>
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string personsFileName)
        {
            List<TeamModel> output = new List<TeamModel>();

            List<PersonModel> persons = personsFileName.FullFilePath().LoadFile().ConvertToPersonModel();

            //goes through textfile line by line.
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();

                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];
            

                string[] personIds = cols[2].Split('|');

                foreach (string  id in personIds)
                {
                    t.TeamMembers.Add(persons.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(t);
            }

            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName, string personFileName, string prizesFileName )
        {
            //id, TournamentName, EntryFee, (Id|Id|Id - EnteredTeams), (Id|Id|Id - Prizes), (Rounds - Id^Id^Id|Id^Id^Id|Id^Id^Id|)

            List<TournamentModel> output = new List<TournamentModel>();

            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(personFileName);
            List<PrizeModel> prizes = prizesFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel t = new TournamentModel();

                t.Id = int.Parse(cols[0]);
                t.TournamentName = cols[1];
                t.EntryFee = decimal.Parse(cols[2]);
                t.Active = 1; //int.Parse(cols[3]); 


                
                string[] teamIds = cols[4].Split('|');
                foreach (string TeamId in teamIds)
                {
                    t.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(TeamId)).First());
                }

                string[] prizesIds = cols[5].Split('|');
                foreach (string prizesId in prizesIds)
                {
                    t.Prizes.Add(prizes.Where(x => x.Id == int.Parse(prizesId)).First());
                }
                //TODO - Capture rounds information.
                output.Add(t);

                
            }

            return output;
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)  
            {
                lines.Add($@"{tm.Id}
                ,{tm.TournamentName}
                ,{tm.EntryFee}
                ,{ConvertTeamListToString(tm.EnteredTeams)}
                ,{ConvertPrizeListToString(tm.Prizes)}
                ,{ConvertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r)}";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        /// <summary>
        /// Helper function to extract the team Id in the format "Id|Id|Id"
        /// </summary>
        /// <param name="teams"></param>
        /// <returns></returns>
        private static string  ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }


        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {

            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {

                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();

                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.Email = cols[3];

                p.CellphoneNumber = cols[4]; //TODO = may not exist.

                output.Add(p);

            }

            return output;

        }

       public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<String> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage} ");
            }


            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                string output = "";

                output += $"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}";

                lines.Add(output);

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        /// <summary>
        /// Helper method for @SaveToTeamFile
        /// </summary>
        /// <param name="persons"></param>
        /// <returns></returns>
        private static string ConvertPeopleListToString(List<PersonModel> persons)
        {
            if (persons.Count == 0)
            {
                return "";
            }
            string personsId = "";
            foreach (PersonModel p in persons)
            {
                personsId += $"{p.Id}|";
            }
            return personsId.Substring(0, personsId.Length - 1);
        }

        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {


            List<String> lines = new List<String>();

            foreach (PersonModel p in models)
            {

                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.Email}, {p.CellphoneNumber}");


            }

            File.WriteAllLines(fileName.FullFilePath(), lines);


        }


    }
}
