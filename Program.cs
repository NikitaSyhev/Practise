using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 2)
            {
                string fileRead = args[0];
                string fileRegex = args[1];
                string regexInFile = File.ReadAllText(fileRegex); //прочитали весь текст c Regex и записали

                try
                {
                    string file = File.ReadAllText(fileRead); // прочитали весь текст с файла  и записали
                    Regex regex = new Regex(regexInFile);
                    MatchCollection match = Regex.Matches(file, regexInFile);

                    foreach (Match m in match)
                    {
                        Console.WriteLine(m.Value);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Нам нужно: 1. передать 2 аргумента командной строки через пробел: сначала файл, затем файл с Regex \n 2.Через регулярные выражения мы можем спарсить только почту>");
            }
              
                
               
            
            

         


            Console.ReadLine();
        }
    }
}
