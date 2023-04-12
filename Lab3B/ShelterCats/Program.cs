// See https://aka.ms/new-console-template for more information
string maleCatsAsString;
string femaleCatsAsString;
int maleCats;
int femaleCats;
//
Console.Write("How many male cats are in the shelter?");
maleCatsAsString = Console.ReadLine();
Console.Write("How many female cats are in the shelter?");
femaleCatsAsString = Console.ReadLine();
maleCats = Convert.ToInt32(maleCatsAsString);
femaleCats = Convert.ToInt32(femaleCatsAsString);
//
float totalCats = maleCats + femaleCats;
float malePercent = maleCats / totalCats * 100;
float femalePercent = femaleCats / totalCats * 100;
//
Console.Write("In the shelter, " + malePercent + "% of cats are male, " + femalePercent + "% of cats are female.");