// Написать программу соответствующую следующим условиям: 
// в ведомости указана зарплата, выплаченная каждому из сотрудников фирмы за месяц. 
// Определить общую сумму выплаченных по ведомости денег.

string buf1;
Console.WriteLine("Введите значение зарплаты одного сотрудника:");
buf1 = Console.ReadLine();
double p = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите число сотрудников:");
buf2 = Console.ReadLine();
double num = Convert.ToDouble(buf2);

Console.WriteLine("Общая сумма выплаченных по ведомости денег равна: {0}", + (p*num));



