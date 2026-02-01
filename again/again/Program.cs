using System.Xml;

namespace again
{
    public class GenericList<t>
    {
        public void Add(t item) { }
    }
    class program
    {
        static void Main(string[] args)
        {
            //string name = Prompt("What is your name? ", false);
            //int nameLength = name.Replace(" ", "").Length;
            //int nameWords = 1 + name.Trim().Count(f => f == ' ');

            //Console.WriteLine($"Your name is {TitleCase(name.Trim())}, your name has {nameLength} letters, and is {nameWords} words.");
            for (int i = 0; i < 100; i++) 
            {
                Console.WriteLine(Looper("", i));
            }
        }
        static string Looper(string str, int frame)
        {
            string result = "";
            int frameMod = frame % 4;
            switch (frameMod)
            {
                case 0:
                    result = "12345";
                    break;
                case 1:
                    result = "23451";
                    break;
                case 2:
                    result = "34512";
                    break;
                case 3:
                    result = "45123";
                    break;
                case 4:
                    result = "51234";
                    break;
            }
            Thread.Sleep(50);
            return result;
        }
        static string TitleCase(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[Math.Max(0,i-1)] == ' '&& str[i] != ' ' || i==0)
                {
                    result+= str[i].ToString().ToUpper();
                }
                else
                {
                    result+= str[i].ToString().ToLower();
                }
                
            }
            return result;
        }
        static string CamelCase(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                
                if (str[Math.Max(0, i - 1)] == ' ' && str[i] != ' ')
                {
                    result += str[i].ToString().ToUpper();
                } else if (str[i] != ' ')
                {
                    result += str[i].ToString().ToLower();
                }
            }
            return result;

        }
        static string Prompt(string prompt, bool newLine)
        {
            string result = "";
            if (newLine)
            {
                Console.WriteLine(prompt);
            } else 
            { 
                Console.Write(prompt);
            }
            result = Console.ReadLine();
            return result;
        }
    }
}