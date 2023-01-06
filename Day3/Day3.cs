namespace Day3
{
    public class Day3Program
    {
        public static void FullDay3Method(string[] day3textarray)
        {
            void StringPuller(string[] day3textarray)
            {
                int totalscore = 0;
                foreach (string i in day3textarray)
                {
                    totalscore += MatchingItemCheck(i);
                }
                Console.Write("Day three first problem: ");
                Console.WriteLine(totalscore);
            }

            void TriosPuller(string[] day3textarray)
            {
                int totalBadgeScore;
                totalBadgeScore = JaggedTrioArrayToScore(TextArrayToTrios(day3textarray));
                Console.Write("Day three second problem: ");
                Console.WriteLine(totalBadgeScore + "\n");
            }

            string[][] TextArrayToTrios(string[] day3textarray)
            {
                string[][] arrayOfTrios = new string [1000][];
                int trioIndex = 0;
                for (int i = 0; i < day3textarray.Length; i++)
                {
                    if ((i-1)%3 == 0)
                    {
                        arrayOfTrios[trioIndex] = new string[3] {day3textarray[i-1], day3textarray[i], day3textarray[i+1]};
                        trioIndex +=1;
                    }
                }
                return arrayOfTrios;
            }

            int JaggedTrioArrayToScore(string[][] arrayOfTrios)
            {
                int totalBadgeScore = 0;
                foreach (string[] trio in arrayOfTrios)
                {
                    if (trio == null)
                    {
                        break;
                    }
                    char[] charArray1 = trio[0].ToCharArray();
                    char[] charArray2 = trio[1].ToCharArray();
                    char[] charArray3 = trio[2].ToCharArray();
                    char badgeLetter = ' ';
                    foreach (char i in charArray1)
                    {
                        foreach (char j in charArray2)
                        {
                            if (j == i)
                            {
                                foreach (char k in charArray3)
                                {
                                    if (k == j)
                                    {
                                        badgeLetter = k;
                                        break;
                                    }
                                }
                                if (i == badgeLetter)
                                {
                                    break;
                                }
                            }
                        }
                        if (i == badgeLetter)
                        {
                            break;
                        }
                    }
                    totalBadgeScore += ItemPriorityFinder(badgeLetter);
                }
                return totalBadgeScore;
            }

            char[] BackPackPart1Finder(string backpack)
            {
                char[] backpackContentsArray;
                backpackContentsArray = backpack.ToCharArray();
                char[] backpackFirstHalfContentsArray;
                backpackFirstHalfContentsArray = backpackContentsArray.Take(backpackContentsArray.Length / 2).ToArray();
                return backpackFirstHalfContentsArray;
            }

            char[] BackPackPart2Finder(string backpack)
            {
                char[] backpackContentsArray;
                backpackContentsArray = backpack.ToCharArray();
                char[] backpackSecondHalfContentsArray;
                backpackSecondHalfContentsArray = backpackContentsArray.Skip(backpackContentsArray.Length / 2).ToArray();
                return backpackSecondHalfContentsArray;
            }

            int ItemPriorityFinder(char item)
            {
                char[] itemPriorityArray = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                int x = 0;
                foreach (char i in itemPriorityArray)
                {
                    if (i == item)
                    {
                        x = Array.IndexOf(itemPriorityArray, i) + 1;
                    }
                }
                return x;
            }

            int MatchingItemCheck(string backpack)
            {
                char[] backpack1 = BackPackPart1Finder(backpack);
                char[] backpack2 = BackPackPart2Finder(backpack);
                char itemvalue = ' ';
                foreach (char i in backpack1)
                {
                    foreach(char j in backpack2)
                    {
                        if (i == j)
                        {
                            itemvalue = j;
                            break;
                        }
                    }
                }
                return ItemPriorityFinder(itemvalue);
            }

            StringPuller(day3textarray);
            TriosPuller(day3textarray);

        }
        
    }
}