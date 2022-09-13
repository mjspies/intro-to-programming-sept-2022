using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goals
{
    public static class GoalsData
    {
        public const string filePath = @"C:\Users\ITUStudent\dev\intro-to-programming-sept-2022\GoalsSolution\Goals\goals.txt";
        public static void GetData()
        {
            if(File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    foreach (string ln in lines)
                    {
                        string[] data = ln.Split("||");
                        Console.WriteLine($"{data[0]}\r\n{data[1]}");
                    }
                }

            }
        }
        public static void AddEntry(Goal goal)
        {
 
            using (TextWriter tw = new StreamWriter(filePath, true))
            {
                tw.WriteLine($"{goal.entryDate} || {goal.goal}");
                tw.Close();
            }
            Console.WriteLine(">> entry saved to journal");
                
          
        }
    }
}
