using System;
using System.IO;

namespace StudentDataViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Mcases\\PracticeProjectFile.txt";

            try
            {
              
                string[] lines = File.ReadAllLines(filePath);

                
                foreach (string line in lines)
                {
                    string[] studentData = line.Split(',');
                    string name = studentData[0];
                    int age = int.Parse(studentData[1]);
                    string grade = studentData[2];

                    Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
                }
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine(); 
        }
    }
}
