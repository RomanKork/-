using System.Collections.Specialized;

internal class Programsssd
{
    private static void Main(string[] args)
    {
        Programsssd program = new Programsssd();

        Console.WriteLine("Сейчас вам предстоит заполнить данные для 20 задач. \n    Задача 1. Введите два числа для двух тестов:");
        int number = int.Parse(Console.ReadLine());
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первым числом: " + program.sumLastNums(number) + ". Тест со вторым числом: " + program.sumLastNums(number1));

        Console.WriteLine("\n    Задача 2. Введите два числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первым числом: " + program.isPositive(number) + ". Тест со вторым числом:" + program.isPositive(number1));

        Console.WriteLine("\n    Задача 3. Введите две буквы для двух тестов: ");
        char letter = char.Parse(Console.ReadLine());
        char letter1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первой буквой: " + program.isUpperCase(letter) + ". Тест со второй буквой: " + program.isUpperCase(letter1));

        Console.WriteLine("\n    Задача 4. Введите четыре числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первой парой чисел: " + program.isDivisor(number, number1) + ". Тест со второй парой чисел: " + program.isDivisor(number2, number3));

        Console.WriteLine("\n    Задача 5. Введите десять чисел: ");
        for (int i = 1; i <= 5; i++)
        {
            number = int.Parse(Console.ReadLine());
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Тест номер " + i + ": " + program.lastNumSum(number, number1));
        }

        Console.WriteLine("\n    Задача 6. Введите четыре числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        number2 = int.Parse(Console.ReadLine());
        number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первой парой чисел: " + program.safeDiv(number, number1) + ". Тест со второй парой чисел: " + program.safeDiv(number2, number3));

        Console.WriteLine("\n    Задача 7. Введите четыре числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        number2 = int.Parse(Console.ReadLine());
        number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первой парой чисел: " + program.makeDecision(number, number1) + ". Тест со второй парой чисел: " + program.makeDecision(number2, number3));

        Console.WriteLine("\n    Задача 8. Введите шесть чисел для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        number2 = int.Parse(Console.ReadLine());
        number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первой тройкой чисел: " + program.sum3(number, number1, number2) + ". Тест со второй тройкой чисел: " + program.sum3(number3, number4, number5));

        Console.WriteLine("\n    Задача 9. Введите три числа для трёх тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первым числом: " + program.age(number) + ". Тест со вторым числом: " + program.age(number1) + ". Тест с третьим числом: " + program.age(number2));

        Console.WriteLine("\n    Задача 10. Введите два дня недели для двух тестов: ");
        string str = Console.ReadLine();
        string str1 = Console.ReadLine();
        Console.Write("Тест с первым днём недели: ");
        program.printDays(str);
        Console.Write("Тест с вторым днём недели: ");
        program.printDays(str1);

        Console.WriteLine("\n    Задача 11. Введите два числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первым числом: " + program.reverseListNums(number) + ". Тест со вторым числом: " + program.reverseListNums(number1));

        Console.WriteLine("\n    Задача 12. Введите четыре числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        number2 = int.Parse(Console.ReadLine());
        number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первой парой чисел: " + program.pow(number, number1) + ". Тест со второй парой чисел: " + program.pow(number2, number3));

        Console.WriteLine("\n    Задача 13. Введите два числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первым числом: " + program.equalNum(number) + ". Тест со вторым числом: " + program.equalNum(number1));

        Console.WriteLine("\n    Задача 14. Введите два числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первым числом: ");
        program.leftTriangle(number);
        Console.WriteLine("Тест со вторым числом: ");
        program.leftTriangle(number1);

        Console.WriteLine("\n    Задача 15. Давайте поиграем в угадайку");
        program.guessGame();

        Console.WriteLine("\n    Задача 16. Введите два числа для двух тестов: ");
        Random r = new Random();
        int[] arr = new int[10];
        Console.Write("Массив:");
        for (int i = 0; i < 10; i++)
        {
            arr[i] = r.Next(0,10);
            Console.Write(" " + arr[i]);
        }
        Console.WriteLine("\nВведите два числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Тест с первым числом: " + program.findLast(arr,number) + ". Тест со вторым числом: " + program.findLast(arr,number1));
        Console.WriteLine("\n    Задача 17. Введите четыре числа для двух тестов: ");
        number = int.Parse(Console.ReadLine());
        number1 = int.Parse(Console.ReadLine());
        number2 = int.Parse(Console.ReadLine());
        number3 = int.Parse(Console.ReadLine());
        int[] arr52 = new int[10];
        Console.Write("Массив:");
        for (int i = 0; i < 10; i++)
        {
            arr52[i] = r.Next(0, 10);
            Console.Write(" " + arr[i]);
        }
        Console.WriteLine("\nТест с первой парой чисел: ");
        int[] massiv = program.add(arr52, number, number1);
        for (int i = 0; i < massiv.Length; i++)
            Console.Write(" " + massiv[i]);
        Console.WriteLine("\nТест со второй парой чисел: ");
        massiv = program.add(arr52, number2, number3);
        for (int i = 0; i < massiv.Length; i++)
            Console.Write(" " + massiv[i]);

        Console.WriteLine("\n\n   Задача 18. Вам ничего не надо вводить: ");
        Console.Write("Массив:");
        for (int i = 0; i < 10; i++)
        {
            arr[i] = r.Next(0, 10);
            Console.Write(" " + arr[i]);
        }
        Console.Write("\nИзменённый массив:");
        program.reverse(arr);

        Console.WriteLine("\n\n    Задача 19. Вам ничего не надо вводить, массивы сгенерируюся автоматический: ");
        Random ran = new Random();
        int[] arr4 = new int[10];
        Console.Write("Массив:");
        for (int i = 0; i < 10; i++)
        {
            arr4[i] = ran.Next(0, 10);
            Console.Write(" " + arr4[i]);
        }
        int[] arr5 = new int[10];
        Console.Write("\nМассив №2:");
        for (int i = 0; i < 10; i++)
        {
            arr5[i] = ran.Next(0, 10);
            Console.Write(" " + arr5[i]);
        }
        int[] massiv3 = program.concat(arr4, arr5);
        Console.Write("\nИзменённый массив: ");
        for (int i = 0; i < massiv3.Length; i++)
            Console.Write(" " + massiv3[i]);

        Console.WriteLine("\n\n    Задача 20. Вам ничего не надо вводить, массив сгенерируется автоматический: ");
        int[] arr6 = new int[10];
        Console.Write("Массив:");
        for (int i = 0; i < 10; i++)
        {
            arr6[i] = ran.Next(-9, 10);
            Console.Write(" " + arr6[i]);
        }
        int[] massiv4 = program.deleteNegative(arr6);
        Console.Write("\nИзменённый массив: ");
        for (int i = 0; i < massiv4.Length; i++)
            Console.Write(" " + massiv4[i]);

    }
    public int sumLastNums(int x)
    {
        return x % 10 + (x / 10) % 10;
    }
    public bool isPositive(int x){
        if (x > 0)
            return true;
        else 
            return false;
    }
    public bool isUpperCase(char x)
    {
        if (char.IsUpper(x)) return true;
        else return false;
    }
    public bool isDivisor(int a, int b)
    {
        if (a % b == 0 || b % a == 0)
            return true;
        return false;
    }
    public int lastNumSum(int a, int b)
    {
        return (a + b) % 10;
    }
    public double safeDiv(int x, int y)
    {
        if(y != 0)
            return x / y;
        return 0;
    }
    public String makeDecision(int x, int y)
    {
        if (x > y)
            return $"{x} > {y}";
        if (x < y)
            return $"{x} < {y}";
        return $"{x} == {y}";
    }
    public bool sum3(int x, int y, int z)
    {
        if (x + z == y || x + y == z || y + z == x)
            return true;
        return false;
    }
    public String age(int x)
    {
        if (x % 10 == 1 && x != 11)
            return $"{x} год";
        if (x % 10 >= 2 && x % 10 <= 4 && (x > 14 || x < 12))
            return $"{x} года";
        return $"{x} лет";
    }
    public void printDays(String x)
    {
        switch(x){
            case "понедельник":
                Console.WriteLine("понедельник вторник среда четверг пятница суббота воскресенье");
                break;
            case "вторник":
                Console.WriteLine("вторник среда четверг пятница суббота воскресенье");
                break;
            case "среда":
                Console.WriteLine("среда четверг пятница суббота воскресенье");
                break;
            case "четверг":
                Console.WriteLine("четверг пятница суббота воскресенье");
                break;
            case "пятница":
                Console.WriteLine("пятница суббота воскресенье");
                break;
            case "суббота":
                Console.WriteLine("суббота воскресенье");
                break;
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }
    public String reverseListNums(int x)
    {
        string s = "";
        while (x >= 0)
        {
            s += x;
            s += ' ';
            x -= 1;
        }
        return s;
    }
    public int pow(int x, int y)
    {
        int z = 1;
        while (y != 0)
        {
            z *= x;
            y--;
        }
        return z;
    }
    public bool equalNum(int x)
    {
        while (x > 9)
        {
            if (x % 10 == (x / 10) % 10)
                x /= 10;
            else
                return false;
        }
        return true;
    }
    public void leftTriangle(int x)
    {
        string s = "";
        while (x != 0)
        {
            s += '*';
            x -= 1;
            Console.WriteLine(s);
        }
    }
    public void guessGame()
    {
        Console.WriteLine("Введите число от 0 до 9");
        Random r = new Random();
        int x = -1, y = r.Next(0,10), z = 0;
        while (x != y)
        {
            z++;
            x = int.Parse(Console.ReadLine());
            if (y == x)
                Console.WriteLine($"Вы угадали! Вы это сделали всего лишь с {z} попытки");
            else Console.WriteLine("Вы не угадали, попробуйте ещё раз, введите число от 0 до 9");
        }
    }
    public int findLast(int[] arr, int x)
    {
        int cnt = -1;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == x)
                cnt = i;
        return cnt;
    }
    public int[] add(int[] arr, int x, int pos)
    {
        int[] array = new int[arr.Length + 1];
        int z = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == pos)
            {
                array[i] = x;
                z++;
            }
            array[i + z] = arr[i];
        }
        return array;
    }
    public void reverse(int[] arr)
    {
        int x;
        for (int i = 0; i < arr.Length/2; i++)
        {
            x = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = x;
        }
        for (int i = 0; i < arr.Length; i++)
            Console.Write(" " + arr[i]);
    }
    public int[] concat(int[] arr1, int[] arr2)
    {
        int[]array = new int[arr1.Length + arr2.Length];
        for (int i = 0;i < arr1.Length;i++)
            array[i] = arr1[i];
        for (int i = 0;i < arr2.Length;i++)
            array[arr1.Length + i] = arr2[i];
        return array;
    }
    public int[] deleteNegative(int[] arr)
    {
        int x = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] < 0)
                x++;
        int[] array = new int[arr.Length - x];
        x = 0;
        for (int i = 0;i < arr.Length; i++)
        {
            if (arr[i] < 0)
                x++;
            else
                array[i - x] = arr[i];
        }
        return array;
    }
}

