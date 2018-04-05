using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeJamWrapper
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputFile = args[0];

            using (StreamReader sr = new StreamReader(inputFile))
            {
                if (sr.Peek() < 0)
                    return;
                var testCount = int.Parse(sr.ReadLine());
                Console.WriteLine(testCount);
                for (int i = 0; i < testCount; i++)
                {
                    var testData = sr.ReadLine();
                    char[] testDataArr = testData.ToCharArray();

                    //CallMyAnswer it will take a char array of the input are return a string answer 
                    string answer = myAnswer(testDataArr);

                    writeToFile(answer);
                  
                }
            }

        }

        static void writeToFile(string val)
        {

            string path = "C:\\Users\\James\\Desktop\\Output\\test.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(val);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(val);
                }
            }

        }

         static string myAnswer(char[] line)
        {

            //program logic here



            return null;
        }

    }
}