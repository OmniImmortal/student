
    class Calculator
{
    static void Main()
    {
        action();
    }
    static void action()
    {
        double value1, value2, result;
        while (true)
        {
            Console.Clear();
        Console.WriteLine("Вы запустили калькулятор. Введите два числа над которыми будеn произведена операция.");
        var value1var = Console.ReadLine();
        var value2var = Console.ReadLine();
        bool valueisdouble1 = double.TryParse(value1var, out value1);
        bool valueisdouble2 = double.TryParse(value2var, out value2);
        Console.WriteLine("Введите символ операции которой хотели бы выполнить(+. -, *, /).");
        string operation = Console.ReadLine();
            if (valueisdouble1 == valueisdouble2)
            {
                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        Console.WriteLine("Сумма " + value1 + " и " + value2 + " равна " + result);
                        break;
                    case "-":
                        result = value1 - value2;
                        Console.WriteLine("Разность " + value1 + " и " + value2 + " равна " + result);
                        break;
                    case "*":
                        result = value1 * value2;
                        Console.WriteLine("Произведение " + value1 + " и " + value2 + " равно " + result);
                        break;
                    case "/":
                        if (value2 != 0)
                        {
                            result = value1 / value2;
                            Console.WriteLine("Деление " + value1 + " на " + value2 + " равно " + result);
                        }
                        else Console.WriteLine("На ноль делить нельзя");
                        break;
                    default:
                        Console.WriteLine("Введено некорректное действие");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
            Console.ReadKey();
            }
        }
    }
