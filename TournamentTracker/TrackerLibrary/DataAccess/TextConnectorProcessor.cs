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


        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string personsFileName)
        {
            List<TeamModel> output = new List<TeamModel>();

            List<PersonModel> persons = personsFileName.FullFilePath().LoadFile().ConvertToPersonModel();

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
