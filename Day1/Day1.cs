namespace Day1
{
    class Day1Program
    {
        public static void FullDay1Method(string day1text)
        {
            string[] eachElfCalArray = day1text.Split("\n\n");

            int[] finalElfArray = new int[1000000];

            for (int i = 0; i < eachElfCalArray.Length; i++)
            {
                int[] elfarray2numeric = new int[1000000];
                string[] elfarray1 = eachElfCalArray[i].Split("\n");
                for (int j = 0; j < elfarray1.Length; j++)
                {
                    int parsedvalue;
                    if (int.TryParse(elfarray1[j], out parsedvalue))
                    {
                    elfarray2numeric[j] = Int32.Parse(elfarray1[j]);
                    }
                }
                int elfcalorietotal = elfarray2numeric.Sum();

                finalElfArray[i] = elfcalorietotal;
            }

            int highestcalorievalue = finalElfArray.Max();
            int elfwiththemostcalories = finalElfArray.ToList().IndexOf(highestcalorievalue) + 1;

            Console.Write("Day one first problem: ");
            Console.WriteLine(highestcalorievalue);

            Array.Sort(finalElfArray);
            Array.Reverse(finalElfArray);
            Console.Write("Day one second problem: ");
            Console.WriteLine(finalElfArray[0]+finalElfArray[1]+finalElfArray[2] + "\n");
            }
    }
}