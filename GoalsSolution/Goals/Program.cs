
using Goals;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.IO;


try
{
    if(File.ReadAllLines(GoalsData.filePath).Length>0)
    {
        Console.WriteLine("Would you like to view previous journal entries?");
        if(Console.ReadLine().Equals("y") || Console.ReadLine().Equals("Y"))
        {
            GoalsData.GetData();
        }
    }
    Goal goal = new Goal();
    if(!goal.goal.Equals(""))
    {
        Console.WriteLine("[Save Changes (y/n)]");
        if (Console.ReadLine().Equals("y") || Console.ReadLine().Equals("Y"))
        {
            GoalsData.AddEntry(goal);
        }
    }
}
catch(Exception e)
{
    Console.WriteLine(e.ToString());
}