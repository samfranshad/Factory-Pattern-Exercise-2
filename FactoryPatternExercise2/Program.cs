namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use?");
            string userInput = Console.ReadLine().ToLower();

            IDataAccess userDataAccess = DataAccessFactory.GetDataAccessType(userInput);

            userDataAccess.LoadData();
            userDataAccess.SaveData();
        }
    }
}
