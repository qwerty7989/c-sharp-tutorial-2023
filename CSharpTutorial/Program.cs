
// ? Part 1 - First time C#
var testVar = "Hello";

Console.WriteLine(testVar);
Console.Beep();


// ? Part 2 - Variables & Data Types
int i = 99;
string s = "abc"; // typical string but small s.
byte b = 255; // range 2^8, 0-255
char c = 'a'; // a lot of unicode type
double e = 2.17; // ^300 float digits
float f = 3.14f; // 10^30 float digits
decimal d = .121212121m; // Precised 28 float digits

// int
i += 1; // i = i + 1
i -= 2; // i = i - 2;
i *= 3; // i = i * 3;
i /= 4; // i = i / 4;
i %= 5; // i = i % 5;

// string
s = "abc" + "efg";


double wrongAssignedDouble = 7 / 2;
// or 7 / 2.0 at least double or float must be in the operation
double rightAssignedDouble = 7.0 / 2;


// ? Part 3 - Type Casting (Implicit VS. Explicit)


// Implicit (The compiler will convert for you.)
int thisIsInt = 13;
long thisIsLong = thisIsInt; // Compiler: I gotcha, man! 

double thisIsDouble = 2.31;
int thisIsIntDou = (int)thisIsDouble; 


// Explicit (You must do the convert yourself.)
string thisIsNumStr = "ADD45";
int result = 0;
if(int.TryParse(thisIsNumStr, out result))
{
    Console.WriteLine("Success: " + result);
}
else
{
    Console.WriteLine("Failure.");
}


