namespace Day2
{
    public class Day2Program
    {
        public static void FullDay2Method(string[] day2textarray)
        {

            void LetterPuller(string[] day2textarray) {
                int totalscore = 0;
                foreach (string i in day2textarray)
                {
                    char[] letterarray;
                    letterarray = i.ToCharArray(0,3);
                    char elfletter = letterarray[0];
                    char myletter = letterarray[2];
                    int roundscore = StringToNumbers(myletter) + WinLoseDrawScore(elfletter, myletter);
                    totalscore += roundscore;
                }
                Console.Write("Day two first problem: ");
                Console.WriteLine(totalscore);
            }


            int StringToNumbers(char letter) {
                if (letter == 'A' || letter == 'X')
                {
                    return 1;
                }
                else if (letter == 'B' || letter == 'Y')
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }

            int WinLoseDrawScore(char elfletter, char myletter){
                int elfhand = StringToNumbers(elfletter);
                int myhand = StringToNumbers(myletter);

                if (myhand == 3 && elfhand == 1)
                {
                    return 0;
                }
                else if (elfhand == 3 && myhand == 1)
                {
                    return 6;
                }
                else if (elfhand == myhand)
                {
                    return 3;
                }
                else if (myhand > elfhand)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }

            void Part2Method(string[] day2textarray){
                int totalscorewithdecider = 0;
                foreach (string i in day2textarray)
                {
                    char[] letterarray;
                    letterarray = i.ToCharArray(0,3);
                    char elfletter = letterarray[0];
                    char mystrategyletter = letterarray[2];
                    char myletter = WinLoseDrawDecider(elfletter, mystrategyletter);
                    int roundscore = StringToNumbers(myletter) + WinLoseDrawScore(elfletter, myletter);
                    totalscorewithdecider += roundscore;
                }
                Console.Write("Day two second problem: ");
                Console.WriteLine(totalscorewithdecider);
            }

            char WinLoseDrawDecider(char elfletter, char mystrategyletter){
                char myletter = 'x';
                char[] rockpaperscissors = {'A','B','C','A'};
                int elfrpsindex = Array.IndexOf(rockpaperscissors, elfletter);
                if (mystrategyletter == 'X' && elfrpsindex != 0) {
                    myletter = rockpaperscissors[elfrpsindex - 1];
                }
                else if (mystrategyletter == 'X') {
                    myletter = 'C';
                }
                else if (mystrategyletter == 'Y'){
                    myletter = rockpaperscissors[elfrpsindex];
                }
                else {
                    myletter = rockpaperscissors[elfrpsindex + 1];
                }
                return myletter;
            }

            LetterPuller(day2textarray);
            Part2Method(day2textarray);
        }
    }
}
