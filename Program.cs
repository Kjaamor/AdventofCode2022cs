using Day1;
using Day2;
using Day3;

Console.WriteLine("\nADVENT OF CODE\n");

//DAY 1
string day1text = File.ReadAllText(@"/Users/james.okeefe/ChaletDecember22/AdventofCodeInCSharp/Day1/day1input1.txt");
Day1Program.FullDay1Method(day1text);

//DAY 2
string[] day2textarray = File.ReadAllLines(@"/Users/james.okeefe/ChaletDecember22/AdventofCodeInCSharp/Day2/day2fullinput.txt");
Day2Program.FullDay2Method(day2textarray);

//DAY 3 IN PROGRESS
string[] day3textarray = File.ReadAllLines(@"/Users/james.okeefe/ChaletDecember22/AdventofCodeInCSharp/Day3/day3fullinput.txt");
Day3Program.FullDay3Method(day3textarray);