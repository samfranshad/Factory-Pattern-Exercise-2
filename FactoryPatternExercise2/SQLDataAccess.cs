using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Reading data from a SQL database");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to a SQL database");
        }
    }
}
