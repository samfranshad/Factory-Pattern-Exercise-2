using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Reading data from a Mongo database");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to a Mongo database");
        }
    }
}
