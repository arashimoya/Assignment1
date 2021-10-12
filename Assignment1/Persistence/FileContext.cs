using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace FileData
{
    public class FileContext
    {
        //public IList<Family> Families { get; private set; }
        public IList<Adult> Adults { get; private set; }

        //private readonly string familiesFile = "families.json";
        private readonly string adultsFile = "adults.json";

        public FileContext()
        {
            //Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
            
        }
        

        private IList<T> ReadData<T>(string s)
        {
            //using (var jsonReader = File.OpenText(familiesFile))
            using (var jsonReader = File.OpenText(adultsFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void AddAdult(Adult adult)
        {
            int max = Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            Adults.Add(adult);
            SaveChanges();
        }

        public void RemoveAdult(int AdultId)
        {
            Adult toRemove = Adults.First(a => a.Id == AdultId);
            Adults.Remove(toRemove);
            SaveChanges();
        }

        public void Update(Adult adult)
        {
            Adult toUpdate = Adults.First(a => a.Id == adult.Id);
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Age = adult.Age;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.Sex = adult.Sex;
            SaveChanges();
        }

        public Adult Get(int id)
        {
            return Adults.FirstOrDefault(a => a.Id == id);
        }
        
        public void SaveChanges()
        {
            // storing families
            /*string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }
            */
            
            //adding persons
            // storing persons
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }
    }
}