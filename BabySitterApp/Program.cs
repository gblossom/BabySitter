using System;

namespace BabySitterApp
{
  public class BabySitter
  {
    static void Main(string[] args)
    {
      // The code provided will print ‘Hello World’ to the console.
      // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
      Console.WriteLine("Hello Git!");
      Console.ReadKey();

      // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
    }

    public string PayForWorkFromTo(int fromtime, int totime)
    {
      //set bedtime as 9:00 PM
      int bedtime = 21;
      //Do math for full hours
      int newfromtime = (fromtime / 100);
      Console.WriteLine(newfromtime);
      int newtotime = ((totime / 100) % 24);
      if (totime % 100 > 0)
        newtotime++;
      Console.WriteLine(newtotime);
      if (newtotime < 17) //before minimum start time
        newtotime += 24;
      Console.WriteLine(newtotime);
      if (newfromtime < 17)
        return "Too Early";
      if (newtotime > 28) //rollover to next morning
        return "Too Late";
      int pay = 0;
      for (int idx = newfromtime; idx < newtotime; idx++)
      {
        if (idx < bedtime)
          pay += 12;
        else if (idx < 24)
          pay += 8;
        else
          pay += 16;
      }
      return pay.ToString();
    }
  }
}
