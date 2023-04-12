// See https://aka.ms/new-console-template for more information
string mealChargeAsString;
int mealCharge;
//
Console.Write("Enter Charge for Meal:");
mealChargeAsString = Console.ReadLine();
mealCharge = Convert.ToInt32(mealChargeAsString);
//
const double TAX_RATE = 0.0675;
double tax = mealCharge * TAX_RATE;
double tip = mealCharge * 0.2;
double total = mealCharge + tax + tip;
//
Console.Write("Your meal charge is $" + mealCharge + ", your tax amount is $" + tax + ",  your tip amount is $" + tip + ", and your total bill is $" + total + ".");