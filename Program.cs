//----------------------------Exercise-1--------------------

using operators;
using System.Diagnostics.CodeAnalysis;

int a = 17;
int b = 4;
int sum = a + b;
int diff = a- b;
double quotient = a / b;
int product = a * b;
double remainder = a % b;
Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

//--------------------------Exercise-2--------------------------

Console.WriteLine("what is the radius of my circle?");
var userResponce= Console.ReadLine();
var radius= double.Parse(userResponce);
var answer= (Methods.AreaOfCircle(radius));
Console.WriteLine($"the are of a circle with the radius of {radius} is {answer}");