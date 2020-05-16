using System;

namespace CheckIdentifier
{
    public class Program
    {
        // вывод на консоль "yes"
        static void OutputYes()
        {
            Console.WriteLine("Yes");
        }
        // вывод на консоль "no"
        static void OutputNo()
        {
            Console.WriteLine("No");
        }
        // проверка на английскую букву
        public static bool IsEnglishLetter(char ch)
        {
            return ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'));
        }

        // проверка на цифру
        public static bool IsDigit(char ch)
        {
            return (ch >= '0' && ch <= '9');
        }

        // является ли строка идентификатором по правилу SR3
        public static bool IsSR3(string identifier)
        {
            // если строка начинается с цифры
            if (IsDigit(identifier[0]))
            {
                OutputNo();
                Console.WriteLine("Identifier cannot begin with a digit!");
                return false;
            }
            // если начинается не с англ. буквы
            if (!IsEnglishLetter(identifier[0]))
            {
                OutputNo();
                Console.WriteLine("Identifier can only begin with a letter!");
                return false;
            }
            // проверяем каждый элемент переменной identifier
            for (int i = 1; i < identifier.Length; i++)
            {
                if (!((IsEnglishLetter(identifier[i])) || IsDigit(identifier[i])))
                {
                    OutputNo();
                    Console.WriteLine("Identifier can contain only letters and numbers!");
                    return false;
                }
            }
            OutputYes();
            Console.WriteLine("");
            return true;
        }
        // проверка на корректный ввод
        public static bool CheckArg(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect number of arguments!" + "\n" +
                    "Usage CheckIdentifier.exe <input string>");
                return false;
            }
            else
                return true;
        }
        static int Main(string[] args)
        {
            // проверка на корректный ввод
            if (!CheckArg(args))
                return 1;

            // присваиваем аргумент командной строки переменной identifier
            string identifier = args[0];

            // является ли строка идентификатором по правилу SR3
            if(!IsSR3(identifier))
                return 1;

            return 0;
        }
    }
}