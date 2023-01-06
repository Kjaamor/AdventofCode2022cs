using System.Linq;

namespace Day4
{
    public class Day4Program
    {
        public static void FullDay4Method(string[] day4textarray)
        {
            int overlapcounter = 0;
            foreach (string line in day4textarray)
            {
                string[] splitStringArray = line.Split(',');
                IEnumerable<int> firstRange = RangeFromString(splitStringArray[0]);
                IEnumerable<int> secondRange = RangeFromString(splitStringArray[1]);
                if (DoesItContainTheOther(firstRange, secondRange) == true)
                {
                    overlapcounter += 1;
                }
            }
            Console.WriteLine("Day four first problem: " + overlapcounter);

            IEnumerable<int> RangeFromString (string halfofString)
            {
                string[] splitHalfofStringArray = halfofString.Split('-');
                int halfStartingNumber = int.Parse(splitHalfofStringArray[0]);
                int halfEndingNumber = int.Parse(splitHalfofStringArray[1]);
                IEnumerable<int> range = Enumerable.Range(halfStartingNumber, halfEndingNumber);
                return range;
            }

            Boolean DoesItContainTheOther(IEnumerable<int> range1, IEnumerable<int> range2)
            {
                if ((range1.Min() >= range2.Min() && range1.Max() <= range2.Max())
                || (range2.Min() >= range1.Min() && range2.Max() <= range1.Max()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        } 
    }
}