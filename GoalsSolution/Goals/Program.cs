
using Goals;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.IO;


try
{
    Goal goal = new Goal();
    if(!goal.goal.Equals(""))
    {
        Console.WriteLine("[Save Changes (y/n)]");
        if (Console.ReadLine().Equals("y") || Console.ReadLine().Equals("Y"))
        {
            Console.WriteLine(goal.goal);
            GoalsData.AddEntry(goal);
        }
    }
}
catch(Exception e)
{
    Console.WriteLine(e.ToString());
}