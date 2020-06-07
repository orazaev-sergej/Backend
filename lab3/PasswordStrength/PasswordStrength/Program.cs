using System;
using System.Linq;

namespace PasswordStrength
{
    public class Program
    {
        public static bool CheckArgs(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect number of arguments!");
                Console.WriteLine("Usage PasswordStrength < input string >");
                return false;
            }
            return true;
        }
        public static bool IsEnglishUppercaseLetter(char ch)
        {
            return (ch >= 'A' && ch <= 'Z');
        }
        public static bool IsEnglishLowercaseLetter(char ch)
        {
            return (ch >= 'a' && ch <= 'z');
        }

        public static bool IsDigit(char ch)
        {
            return (ch >= '0' && ch <= '9');
        }
        public static bool PasswordValidation(string userPassword)
        {
            if (userPassword.Length == 0)
                return false;
            for (int i = 0; i < userPassword.Length; i++)
            {
                if (!(IsEnglishUppercaseLetter(userPassword[i])) && !(IsEnglishLowercaseLetter(userPassword[i])) && !(IsDigit(userPassword[i])))
                {
                    Console.WriteLine("Inavalid Password!\nUse only english letters and numbers");
                    return false;
                }
            }
            return true;
        }
        public static int GetStrengthForAllCharacters(string userPassowrd)
        {
            int numberOfSymbolInPassword = userPassowrd.Length;
            return 4 * numberOfSymbolInPassword;
        }
        public static int GetStrengthForDigits(string userPassword)
        {
            int numberOfDigits = userPassword.Where(char.IsDigit).Count();
            return 4 * numberOfDigits;
        }
        public static int GetStrengthForUpperLetters(string userPassword)
        {
            int upperLetters = 0;
            int passwordStrength = 0;
            for (int i = 0; i < userPassword.Length; i++)
            {
                if (IsEnglishUppercaseLetter(userPassword[i]))
                    upperLetters++;
            }
            if (upperLetters != 0)
                passwordStrength = (userPassword.Length - upperLetters) * 2;
            return passwordStrength;
        }
        public static int GetStrengthForLowerLetters(string userPassword)
        {
            int lowerLetters = 0;
            int passwordStrength = 0;
            for (int i = 0; i < userPassword.Length; i++)
            {
                if (IsEnglishLowercaseLetter(userPassword[i]))
                    lowerLetters++;
            }
            if (lowerLetters > 0)
                passwordStrength = (userPassword.Length - lowerLetters) * 2;
            return passwordStrength;
        }
        public static int GetStrengthForOnlyLetters(string userPassword)
        {
            int passwordStrength = 0;
            for (int i = 0; i < userPassword.Length; i++)
            {
                if (IsDigit(userPassword[i]))
                    return passwordStrength;
            }
            passwordStrength -= userPassword.Length;
            return passwordStrength;
        }
        public static int GetStrengthForOnlyDigits(string userPassword)
        {
            int passwordStrength = 0;
            for (int i = 0; i < userPassword.Length; i++)
            {
                if (!IsDigit(userPassword[i]))
                    return passwordStrength;
            }
            passwordStrength -= userPassword.Length;
            return passwordStrength;
        }
        public static int GetStrengthForRepeatedCharacters(string userPassword)
        {
            int passwordStrength = 0;
            int repeatedChars = 0;

            string userPasswordWithoutRepeatedCh = new string(userPassword.Distinct().ToArray());

            for (int i = 0; i < userPasswordWithoutRepeatedCh.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < userPassword.Length; j++)
                {
                    if (userPassword[j] == userPasswordWithoutRepeatedCh[i])
                        counter++;
                }
                if (counter > 1)
                {
                    repeatedChars += counter;
                }
            }

            passwordStrength -= repeatedChars;

            return passwordStrength;
        }

        public static int PasswordStrengthCheck(string userPassword)
        {
            int passwordStrenght = 0;

            passwordStrenght += GetStrengthForAllCharacters(userPassword);

            passwordStrenght += GetStrengthForDigits(userPassword);

            passwordStrenght += GetStrengthForUpperLetters(userPassword);

            passwordStrenght += GetStrengthForLowerLetters(userPassword);

            passwordStrenght += GetStrengthForOnlyLetters(userPassword);

            passwordStrenght += GetStrengthForOnlyDigits(userPassword);

            passwordStrenght += GetStrengthForRepeatedCharacters(userPassword);

            return passwordStrenght;
        }
        static int Main(string[] args)
        {
            if (!CheckArgs(args))
                return 1;

            string userPassword;
            userPassword = args[0];

            if (!PasswordValidation(userPassword))
                return 1;

            Console.WriteLine(PasswordStrengthCheck(userPassword));

            return 0;
        }
    }
}