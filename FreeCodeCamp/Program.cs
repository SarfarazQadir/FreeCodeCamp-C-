// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// In this task, you'll create a method that adjusts scheduled times to a different GMT time zone.
// The method should accept a list of times,
// the current time zone, and the new time zone. Let's get started!

 int[] schedule = { 800, 1200, 1600, 2000 };

    void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
    {
        int diff = 0;
        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
        }
        else
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
        }

        for (int i = 0; i < times.Length; i++)
        {
            int newTime = ((times[i] + diff)) % 2400;
            Console.WriteLine($"{times[i]} -> {newTime}");
        }
    }

    DisplayAdjustedTimes(schedule, 6, -6);
