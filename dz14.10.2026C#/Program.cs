using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------Task 1-------\n");
        Console.WriteLine("Print number(1/100)");
        string num1 = Console.ReadLine();
        if (int.TryParse(num1, out int number))
        {

                if (number < 1 || number > 100)
                {
                    Console.WriteLine("Число не в діапазоні!");
                }

                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine("Number: " + number);
                }

        }




        Console.WriteLine("-------Task 2-------\n");
        Console.WriteLine("print number:");
        string num2 = Console.ReadLine();
        Console.WriteLine("print prosent:");
        string prosent = Console.ReadLine();
        if(int.TryParse(num2, out int number2) && int.TryParse(prosent, out int pros))
        {
            double result = number2 * pros / 100.0;
            Console.WriteLine("Result: " + result);
        }



        Console.WriteLine("-------Task 3-------\n");

        Console.WriteLine("pint num 1:");
        string n1 = Console.ReadLine();
        Console.WriteLine("pint num 2:");
        string n2 = Console.ReadLine();
        Console.WriteLine("pint num 3:");
        string n3 = Console.ReadLine();
        Console.WriteLine("pint num 4:");
        string n4 = Console.ReadLine();
        string nm4 = n1 + n2 + n3 + n4;
        if(int.TryParse(nm4, out int nm4int))
        {
            Console.WriteLine(nm4int);
        }

        Console.WriteLine("-------Task 4-------\n");
        string str = "723895";
        string reversed = "";

        for (int i = str.Length - 1; i >= 0; i--)
           {
              reversed += str[i];
           }

        Console.WriteLine("Перевёрнутое число: " + reversed);




        Console.WriteLine("-------Task 5-------\n");

        Console.Write("Введите дату (в формате dd.MM.yyyy): ");
        string dateinput = Console.ReadLine();

        if (DateTime.TryParse(dateinput, out DateTime date))
        {
            string season;
            switch (date.Month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    season = "Unknown";
                    break;
            }

            string dayOfWeek = date.DayOfWeek.ToString();
            Console.WriteLine($"{season} {dayOfWeek}");
        }


        Console.WriteLine("-------Task 6-------\n");
        Console.WriteLine("У що переводити? 1.Фаренгейт у Цельсія 2.Цельсія у Фаренгейт");
        string typet = Console.ReadLine();

        Console.WriteLine("Введіть температуру: ");
        string temp = Console.ReadLine();

        if (double.TryParse(temp, out double t))
        {
            switch (typet)
            {
                case "1":
 
                    double celsius = (t - 32) * 5.0 / 9.0;
                    Console.WriteLine($"{t}°F = {celsius:F1}°C");
                    break;
                case "2":
                    double fahrenheit = (t * 9.0 / 5.0) + 32;
                    Console.WriteLine($"{t}°C = {fahrenheit:F1}°F");
                    break;
                default:
                    Console.WriteLine("Невірний вибір операції (виберіть 1 або 2).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Помилка: введено не число.");
        }


        Console.WriteLine("-------Task 7-------\n");
        Console.Write("Введіть перше число: ");
        string nu1 = Console.ReadLine();

        Console.Write("Введіть друге число: ");
        string nu2 = Console.ReadLine();

        if (int.TryParse(nu1, out int nuu1) && int.TryParse(nu2, out int nuu2))
        {
            int start = Math.Min(nuu1, nuu2);
            int end = Math.Max(nuu1, nuu1);

            Console.WriteLine($"{start}..{end}:");

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }


    }
}