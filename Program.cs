using System.Globalization;

CultureInfo cultureInfo = new CultureInfo("en-US");

#region IntegalNumber
/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


Console.WriteLine();

Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
*/
#endregion

#region FloatingPointNumber

/*
Console.WriteLine();
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

#endregion

#region ReferenceType

int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

#endregion

#region PracticeParsing
/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
float total = 0;


foreach(var value in values)
{
    float currentNumber = 0;

    if(float.TryParse(value, cultureInfo , out currentNumber))
        total += currentNumber;
    else   
        message += value;
}

Console.WriteLine("Message : " + message);
Console.WriteLine("Total : " + total);
*/
#endregion

#region PracticeConvert
/*
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2);
decimal result2 = value2 / (decimal)value3;
float result3 = value3 / value1;


// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/
#endregion


