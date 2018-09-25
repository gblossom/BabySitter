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
      if (fromtime < 1700)
        return "Too Early";
      if (totime > 400)
        return "Too Late";
      return null;
    }
  }
}
