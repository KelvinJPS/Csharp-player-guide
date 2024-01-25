Boolean booleanLiteral = false;

// whole numbers 
byte byteLiteral = 255;
sbyte sbyteLiteral= 73;
short shortLiteral = 32767;
int integerLiteral = 2147483647;
long longLiteral = 65535;
ushort ushortLiteral = 65535;
uint uintLiteral = 400000;
ulong ulongLiteral = 100000000000000;

Console.WriteLine("Whole numbers: {0}, {1}, {2}, {3}, {4}, {5}", byteLiteral, sbyteLiteral, shortLiteral, integerLiteral, longLiteral, ushortLiteral);

// real numbers 
float floatLiteral = 1.0f;
double doubleLiteral = 2.5;
decimal decimalLiteral = 40000;

Console.WriteLine("real numbers");
Console.WriteLine("float:" + floatLiteral);
Console.WriteLine("Double:" + doubleLiteral);
Console.WriteLine("Decimal:" + decimalLiteral); 

// Text
char charLiteral = '.';
string stringLiteral = "usigned value cannot hold negative numbers";

Console.WriteLine("text", charLiteral, stringLiteral);

// Change to minimum 

byteLiteral = 0;
sbyteLiteral = 0;
shortLiteral = -32767;
integerLiteral = -2147483647;
longLiteral = -65535;
ushortLiteral = 65535;
uintLiteral = 400000;
ulongLiteral = 100000000000000;

Console.WriteLine("minimum values");
Console.WriteLine("bytye:" +  byteLiteral);
Console.WriteLine("sbyte" +  sbyteLiteral); 
Console.WriteLine("short" +  shortLiteral);
Console.WriteLine("integer" +  integerLiteral);
Console.WriteLine("Long" +  ulongLiteral);
Console.WriteLine("short" +  ushortLiteral);

