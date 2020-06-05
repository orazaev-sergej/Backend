using System;
using System.IO;
using System.Text;

namespace RemoveExtraBlanks
{
    public class Program
    {
        public static bool CheckArg(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Incorrect number of arguments!" + "\n");
                return false;
            }
            return true;
        }

        public static string RemoveExtraBlanks(string inText)
        {
            string finishedText = "";

            inText = inText.Trim();

            for (int i = 0; i < inText.Length; i++)
            {
                if (inText[i] == ' ' || inText[i] == '\t')
                {
                    while (inText[i + 1] == ' ' || inText[i + 1] == '\t')
                    {
                        i++;
                    }
                    finishedText += inText[i];
                }
                else
                    finishedText += inText[i];
            }
            return finishedText;
        }
        static int Main(string[] args)
        {
            if (!CheckArg(args))
                return 1;

            string inputFile = args[0];
            string outputFile = args[1];

            string finishedText = "";

            using (var sr = new StreamReader(inputFile, Encoding.UTF8))
            {
                using (var sw = new StreamWriter(outputFile, false, Encoding.UTF8))
                {
                    var text = "";
                    while ((text = sr.ReadLine()) != null)
                    {
                        finishedText = RemoveExtraBlanks(text);
                        sw.WriteLine(finishedText);
                    }
                }
            }

            return 0;
        }
    }
}
