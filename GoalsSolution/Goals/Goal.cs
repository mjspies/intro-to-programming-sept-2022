using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Goals
{
    public class Goal
    {
        public string goal;
        public string entryDate;
        public Goal()
        { 
            Console.WriteLine("Enter your goal for today:\n--------------------------");
            string? response = Console.ReadLine();
            if(response != null)
            {
                goal = string.Concat(response.Take(256));
                entryDate = GetDateString();
                Console.WriteLine(String.Format(entryDate, "/n", goal));

            }
            else
            {
                Console.WriteLine("Error! no goal has been entered");
            }

            Console.WriteLine(goal);
                       
        }

        static string GetDateString()
        {
            DateTime date = DateTime.Now;
            string day = date.ToString("dddd");
            string formattedDate = date.ToString("MMMM d, yyyy");
            return $"For {day}, {formattedDate} Your Goal is:";
        }

    }
}
