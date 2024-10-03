using System.Text;

namespace ЛАБ1_2курсС_
{
    internal class Program
    {
        public double fraction(double x)
        {
            return x - Math.Floor(x);
        }
        public int charToNum(char x)
        {
            return x - '0';
        }
        public bool is2Digits(int x)
        {
            return (x >= 10 && x <= 99);
        }
        public bool isInRange(int a, int b, int num)
        {
            return a <= num && num <= b || b <= num && num <= a;
        }
        public bool isEqual(int a, int b, int c)
        {
            return a == b && a == c && b == c;
        }
        public int abs(int x)
        {
            if (x < 0)
                return x *(-1);
            else
                return x;
        }
        public bool is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
                return false;
            else
                return true;
        }
        public int max3(int x, int y, int z)
        {
            int max = x;
            if (y > max)
                max = y;
            if (z > max)
                max = z;
            return max;
        }
        public int sum2(int x, int y)
        {
            if (10 <= x + y && x + y <= 19)
                return 20;
            else
                return x + y;
        }
        public string day(int x)
        {
            switch (x)
            {
                case 1:
                    return "понедельник";
                case 2:
                    return "вторник";
                case 3:
                    return "среда";
                case 4:
                    return "четверг";
                case 5:
                    return "пятница";
                case 6:
                    return "суббота";
                case 7:
                    return "воскресенье";
                default:
                    return "это не день недели";
            }
        }
        public string listNums(int x)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <= x; i++)
            {
                result.Append(i + " ");
            }
            return result.ToString();
        }
        public string chet(int x)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0;i <= x; i+= 2)
            {
                result.Append(i + " ");
            }
            return result.ToString();
        }
        public int numLen(long x)
        {
            int length = 0;
            if (x < 0)
                x = -x;
            if (x == 0)
                return 1;
            while (x > 0)
            {
                length++;
                x /= 10;
            }
            return length;
        }
        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            { 
                for (int j = 0; j < x; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        public void rightTriangle(int x)
        {
            for(int i = 1; i <= x; i++)
            {
                for(int j = 0; j < x - i;  j++)
                    Console.Write(" ");
                for (int k = 0; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        public int findFirst(int[] arr, int x)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        public int maxAbs(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] result = new int[arr.Length + ins.Length];
            Array.Copy(arr, 0, result, 0, pos);
            Array.Copy(ins, 0, result, pos, ins.Length);
            Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);
            return result;
        }
        public int[] ReverseBack(int[] arr)
        {
            int[] reversedArr = new int[arr.Length];
            for (int i = 0;i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - i - 1];
            }
            return reversedArr;
        }
        public int[] findAll(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }
            int[] indices = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    indices[index] = i;
                    index++;
                }
            }
            return indices;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int a, b, c, x1, y1, z1, pos;
            int[] arr = {1, 2, 3, 4, 52};
            int[] arr2 = { 52, 53, 54 };
            bool isWorking;
            string str;
            Console.WriteLine("Лабораторная работа №1\n Раздел методы:\nЗадача 1 - 1\nЗадача 3 - 2\nЗадача 5 - 3\nЗадача 7 - 4\nЗадача 9 - 5" +
                "\n Раздел условия:\nЗадача 1 - 6\nЗадача 3 - 7\nЗадача 5 - 8\nЗадача 7 - 9\nЗадача 9 - 10" +
                "\n Раздел Циклы:\nЗадача 1 - 11\nЗадача 3 - 12\nЗадача 5 - 13\nЗадача 7 - 14\nЗадача 9 - 15" +
                "\n Раздел Массивы:\nЗадача 1 - 16\nЗадача 3 - 17\nЗадача 5 - 18\nЗадача 7 - 19\nЗадача 9 - 20");
            Console.WriteLine("Выберите номер задачи");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (num)
            {
                case 1://МЕТОДЫ 1
                    Console.WriteLine("Вы запустили задачу 1, раздел Методы");
                    Console.WriteLine("Введите ввещественное число:");
                    double x = float.Parse(Console.ReadLine());
                    x = program.fraction(x);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(x);
                    break;
                case 2://МЕТОДЫ 3
                    Console.WriteLine("Вы запустили задачу 3, раздел Методы");
                    Console.WriteLine("Введите целое число от 0 до 9:");
                    char ch = char.Parse(Console.ReadLine());
                    int result = program.charToNum(ch);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(result);
                    break;
                case 3://МЕТОДЫ 5
                    Console.WriteLine("Вы запустили задачу 5, раздел Методы");
                    Console.WriteLine("Введите проверяемое число: ");
                    int y = int.Parse(Console.ReadLine());
                    isWorking = program.is2Digits(y);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(isWorking);
                    break;
                case 4://МЕТОДЫ 7
                    Console.WriteLine("Вы запустили задачу 7, раздел Методы");
                    Console.WriteLine("Введите начало границы a:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите начало границы b:");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число, которое хотите проверить:");
                    int number = int.Parse(Console.ReadLine());
                    isWorking = program.isInRange(a, b, number);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(isWorking);
                    break;
                case 5://МЕТОДЫ 9
                    Console.WriteLine("Вы запустили задачу 9, раздел Методы");
                    Console.WriteLine("Введите число a:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число b:");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число c:");
                    c = int.Parse(Console.ReadLine());
                    isWorking = program.isEqual(a, b, c);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(isWorking);
                    break; 
                case 6://УСЛОВИЯ 1
                    Console.WriteLine("Вы запустили задачу 1, раздел Условия");
                    Console.WriteLine("Введите число x: ");
                    x1 = int.Parse(Console.ReadLine());
                    x1 = program.abs(x1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(x1);
                    break;
                case 7://УСЛОВИЯ 3
                    Console.WriteLine("Вы запустили задачу 1, раздел Условия");
                    Console.WriteLine("Введите число x. которое делится на 3 или 5: ");
                    x1 = int.Parse(Console.ReadLine());
                    isWorking = program.is35(x1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(isWorking);
                    break;
                case 8://УСЛОВИЯ 5
                    Console.WriteLine("Вы запустили задачу 3, раздел Условия");
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число y: ");
                    y1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число z: ");
                    z1 = int.Parse(Console.ReadLine());
                    result =  program.max3(x1, y1, z1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(result);
                    break;
                case 9://УСЛОВИЯ 7
                    Console.WriteLine("Вы запустили задачу 7, раздел Условия");
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число y: ");
                    y1 = int.Parse(Console.ReadLine());
                    result = program.sum2(x1, y1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(result);
                    break;
                case 10://УСЛОВИЯ 9
                    Console.WriteLine("Вы запустили задачу 9, раздел Условия");
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    str = program.day(x1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(str);
                    break;
                case 11://ЦИКЛЫ 1
                    Console.WriteLine("Вы запустили задачу 1, раздел Циклы");
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    str = program.listNums(x1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(str);
                    break; 
                case 12://ЦИКЛЫ 3
                    Console.WriteLine("Вы запустили задачу 3, раздел Циклы");
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    str = program.chet(x1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(str);
                    break; 
                case 13://ЦИКЛЫ 5
                    Console.WriteLine("Вы запустили задачу 5, раздел Циклы");
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    x1 = program.numLen(x1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(x1);
                    break; 
                case 14://ЦИКЛЫ 7
                    Console.WriteLine("Вы запустили задачу 7, раздел Циклы");
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ответ: ");
                    program.square(x1);
                    break; 
                case 15://ЦИКЛЫ 9
                    Console.WriteLine("Вы запустили задачу 9, раздел Циклы");
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ответ: ");
                    program.rightTriangle(x1);
                    break;
                case 16://МАССИВЫ 1
                    Console.WriteLine("Вы запустили задачу 1, раздел Массивы");
                    Console.WriteLine("Дан массив arr:");
                    for (int i = 0; i < arr.Length; i++)
                        Console.Write(arr[i] + " ");
                    Console.WriteLine("\nВведите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    x1 = program.findFirst(arr, x1);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(x1);
                    break; 
                case 17://МАССИВЫ 3
                    Console.WriteLine("Вы запустили задачу 3, раздел Массивы");
                    Console.WriteLine("Дан массив arr:");
                    for (int i = 0; i < arr.Length; i++)
                        Console.Write(arr[i] + " ");
                    x1 = program.maxAbs(arr);
                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(x1);
                    break;
                case 18://МАССИВЫ 5
                    Console.WriteLine("Вы запустили задачу 5, раздел Массивы");
                    Console.WriteLine("Дан массив arr:");
                    for (int i = 0; i < arr.Length; i++)
                        Console.Write(arr[i] + " ");
                    Console.WriteLine();
                    Console.WriteLine("Введите число pos: ");
                    pos = int.Parse(Console.ReadLine());
                    arr = program.add(arr, arr2, pos);
                    Console.WriteLine("Ответ: ");
                    for (int i = 0; i < arr.Length; i++)
                        Console.Write(arr[i] + " ");
                    break;
                case 19://МАССИВЫ 7
                    Console.WriteLine("Вы запустили задачу 7, раздел Массивы");
                    Console.WriteLine("Дан массив arr:");
                    for (int i = 0; i < arr.Length; i++)
                        Console.Write(arr[i] + " ");
                    Console.WriteLine();
                    Console.WriteLine("Тот же массив задом наперед: ");
                    arr = program.ReverseBack(arr);
                    Console.WriteLine("Ответ: ");
                    for (int i = 0; i < arr.Length; i++)
                        Console.Write(arr[i] + " ");
                    break;
                case 20://МАССИВЫ 9
                    Console.WriteLine("Вы запустили задачу 7, раздел Массивы");
                    Console.WriteLine("Дан массив arr:");
                    for (int i = 0; i < arr.Length; i++)
                        Console.Write(arr[i] + " ");
                    Console.WriteLine();
                    Console.WriteLine("Введите число х: ");
                    x1 = int.Parse(Console.ReadLine());
                    arr = program.findAll(arr, x1);
                    Console.WriteLine("Ответ: ");
                    for (int i = 0; i < arr.Length; i++)
                        Console.Write(arr[i] + " ");
                    break;
                default:
                    Console.WriteLine("такого номера не существует");
                    break;
            }
        }
    }
}
