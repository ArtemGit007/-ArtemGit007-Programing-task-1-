// Написать программу вывода на экран чисел следующим образом:
//16  15.5  16.8
//17  16.5  17.8
//...
//24  23.5  24.8

double a = 16;
double b = 15.5;
double c= 16.8;
while (a < 25)
{
    Console.WriteLine("{0}  {1}  {2}", a, b, c);

    a++;
    b++;
    c++;
}
Console.WriteLine();

a=16;
b=15.5;
c=16.8;

for (int i = 0; i < 9; i++)
{
    Console.WriteLine("{0}  {1}  {2}", a, b, c);
    
}

do
{
    Console.WriteLine("{0}  {1}  {2}", a, b, c);
    a++;
    b++;
    c++;
}
while (a < 25);

