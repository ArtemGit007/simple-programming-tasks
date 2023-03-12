// Напечатать числа следующим образом:
// 25  25.5  24.8
// 26  26.5  25.8
// ...
// 35  35.5  34.8

double a = 25;
double b = 25.5;
double c = 24.8;

while (a < 36)
{
    Console.WriteLine("{0} {1} {2}", a, b, c);

    a++;
    b++;
    c++;
}
Console.WriteLine();

a = 25.0;
b = 25.5;
c = 24.8;
do
{
    Console.WriteLine("{0}  {1}  {2}", a,b,c);
    a++;
    b++;
    c++;
}
while(a<36);
Console.WriteLine();

a = 25.0;
b = 25.5;
c = 24.8;
for (int i = 0; i < 11; i++)
{
    Console.WriteLine("{0}    {1}    {2}", a,b,c);
}
Console.WriteLine();



