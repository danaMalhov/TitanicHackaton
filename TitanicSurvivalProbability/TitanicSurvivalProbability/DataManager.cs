using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanicSurvivalProbability
{
    public static class DataManager
    {
        static public List<Passenger> Passengers { get; set; }

        static private string FileName { get; set; }

        static DataManager()
        {
            FileName = "";
            Passengers = readFile().ToList();
        }

        static private IEnumerable<Passenger> readFile()
        {
            FileStream fs = new FileStream(FileName, FileMode.Open);

            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(FileName, ".csv"));

            // lines.Select allows me to project each line as a Person. 
            // This will give me an IEnumerable<Person> back.
            return lines.Select(line =>
            {
                string[] data = line.Split(';');

                int id = Convert.ToInt32(data[0]);
                SocialClass sclass = (SocialClass)Convert.ToInt32(data[1]);
                string name = data[2];
                Gender gender = (Gender)Enum.Parse(typeof(SocialClass), data[3]);
                int age = Convert.ToInt32(data[4]);
                double fair = Convert.ToDouble(data[8]);
                int survival = Convert.ToInt32(data[11]);


                // We return a person with the data in order.
                return new Passenger(id, sclass, name, gender, age, fair, survival);
            });
        }
    }
}
