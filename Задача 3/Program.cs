// Имеется серия измерений элементов треугольника. Группы элементов пронумерованы. 
//В серии в произвольном порядке могут встречаться такие группы элементов треугольника: 
//основание и высота; две стороны и угол между ними; три стороны. 
// Разработать программу, которая запрашивает номер группы элементов, 
// вводит соответствующие элементы и вычисляет площадь треугольника. 
// Вычисления прекратить, если в качестве номера группы введен 0.


Console.WriteLine("Введите номер группы элементов треугольника:");
int i = Convert.ToInt32(Console.ReadLine());

if(i == 1)
{
    Console.WriteLine("Введите значение высоты треугольника:");
     int h = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите значение основания треугольника:");
     int c = Convert.ToInt32(Console.ReadLine());
    int s = (h * c)/2;
    Console.WriteLine("Площадь треугольника с высотой {0} и основанием {1} равна {2}", h,c,s);
}

if(i == 2)
{
    string buf1;
    Console.WriteLine("Введите значение стороны a  треугольника:");
    buf1 = Console.ReadLine();
    double a = Convert.ToDouble(buf1);

     string buf2;
    Console.WriteLine("Введите значение стороны b  треугольника:");
    buf2 = Console.ReadLine();
    double b = Convert.ToDouble(buf2);

    string buf3;
    Console.WriteLine("Введите значение угла l между сторонами a и b:");
    buf3 = Console.ReadLine();
    double l = Convert.ToDouble(buf3);
    double x = l*Math.PI/180;
    double s = (Math.Sin(x)*(a*b))/2;
    Console.WriteLine("Площадь треугольника со сторонами {0}, {1} и углу {2}, равна {3}", a,b,l, s);
}

if(i == 3)
{
    Console.WriteLine("Введите значение стороны a треугольника:");
    int a = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите значение стороны b треугольника:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение стороны c треугольника:");
    int c = Convert.ToInt32(Console.ReadLine());
    if((a+b)>c&&(b+c)>a&&(c+a)>b)
    {
    int p = (a+b+c)/2;
    int s = (int)MathF.Sqrt(p*(p-a)*(p-b)*(p-c));
   
    Console.WriteLine("Площадь треугольника со сторонами {0}, {1} и {2} равна {3}", a,b, c, p, s);
    }
    if((a+b)<c||(b+c)<a||(c+a)<b)
    Console.WriteLine("Треугольник, где сумма двух сторон меньше третьей - не существует.");
}

if(i <1||i >3)
Console.WriteLine("Вычисления прекратить - введено неверное значение.");

