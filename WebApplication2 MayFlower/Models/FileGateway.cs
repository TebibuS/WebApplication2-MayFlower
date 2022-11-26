using System.IO;
namespace WebApplication2_MayFlower.Models
{
    public class FileGateway
    {
        public List<Person> GetPeople(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<Person> aListOfPeople = new List<Person>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Person aPerson;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aPerson = new Person(aRow[0], aRow[1]);
                aListOfPeople.Add(aPerson);
                index = index + 1;
            }

            return aListOfPeople;
        }
    }

}