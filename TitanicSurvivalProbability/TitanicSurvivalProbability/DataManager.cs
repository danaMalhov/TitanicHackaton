using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanicSurvivalProbability
{
    public class DataManager
    {
        public List<Passenger> Passengers { get; set; }

        private string FileName { get; set; }

        public DataManager()
        {
            readFile();
        }

        private void readFile()
        {

        }
    }
}
