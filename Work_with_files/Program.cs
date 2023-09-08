// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//using System.IO;
//System.Console.WriteLine("Matnni kiriting:");
//string matn = Convert.ToString(Console.ReadLine());
//string fileName = "example.txt";
//string newfile = "reverse.txt";
//// Create the file
//FileStream fileStream = File.Create(fileName);
//fileStream.Close();
//
//StreamWriter writer = new StreamWriter(fileName);
//writer.WriteLine(matn);
//writer.Close();
//
//
//StreamReader reader = new StreamReader(fileName);
//string fileContents = reader.ReadToEnd();
//string reversedStr = "";
//for (int i = fileContents.Length - 1; i >= 0; i--)
//{
//     reversedStr += fileContents[i];
//}
//
//reader.Close();
//
//StreamWriter writer1 = new StreamWriter(newfile);
//writer1.WriteLine(reversedStr);
//writer1.Close();
//
//Console.WriteLine(fileContents);
//System.Console.WriteLine(reversedStr);
//System.Console.WriteLine();
//using System;
//using System.IO;



int k = 10;
string inputFile = "namel";
string outputFile2 = "Name2.txt";
string outputFile3 = "Name3.txt";

string[] lines = File.ReadAllLines(inputFile);

using (StreamWriter writer2 = new StreamWriter(outputFile2))
using (StreamWriter writer3 = new StreamWriter(outputFile3))
{
     foreach (string line in lines)
     {
          if (line.Length < 3)
          {
               writer2.WriteLine(line);
          }
          else
          {
               writer2.WriteLine(line.Substring(0, 3) + line.Substring(line.Length - 3));
          }

          if (line.Length >= k)
          {
               writer3.WriteLine(line.Substring(0, k));
          }
          else
          {
               writer3.WriteLine("probe");
          }
     }
}



