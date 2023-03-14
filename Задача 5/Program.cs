// Дана непустая последовательность неотрицательных целых чисел, 
//оканчивающаяся отрицательным числом. Найти среднее арифметическое всех чисел 
// последовательности (без учета отрицательного числа).

  int sum, sre, pro, max, min, kp, ko, sp, so;
                float ap, ao;
                //sre = 0; 
                pro = 1;
                kp = 0; ko = 0; max = 1; min = 1; sp = 0; so = 0;
                Console.WriteLine("Введите N:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n - 1; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine()); // Введите элементы массива
                    //sre = sre + a[i];
                    pro = pro * a[i];
                    if (a[i] > 0)
                    {
                        kp++;
                        sp = sp + a[i];
                    }
                    else
                        if (a[i] != 0)
                        {
                            ko++;
                            so = so + a[i];
                        }
 
                }
                    max = a.Max();
                    min = a.Min();
                    sum = a.Sum();
 
                ap = (float)sp / (float)kp;
                ao = (float)so / (float)ko;
 
                Console.WriteLine("Summa={0}, Proizv={1}, Max={2}, Min={3}, Arifm.p={4}, Arifm.o={5}", sum, pro, max, min, ap, ao);
                Console.ReadKey();

