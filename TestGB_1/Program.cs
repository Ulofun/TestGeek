// Возвести число А в степень В

Console.WriteLine("Введите первое число ");
double number_A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double number_B = Convert.ToDouble(Console.ReadLine());
double result = find_number(number_A, number_B);

Console.WriteLine("Результат вычисления равен = " + result);


double find_number( double number_A, double number_B)
{ 
    double find_num = Math.Pow (number_A, number_B);
    double result = find_num;
    return result;
}