using System;
using System.Runtime.CompilerServices;

/// <summary>
/// 1.activity should begin with the standard starting message and prompt for the duration that is used by all activities.
/// 2.Description of this activity should be "This activity will help you relax by guiding you through slow, deep breaths."
/// 3.After the starting message, the user is shown a series of messages alternaing between "breathe in..." and "breathe out...".
/// 4.After each message, the program should pause for several seconds and show a countdown.
/// 5. it should continue until it has reached the number of seconds the user specified for the duration.
/// 6. The activity should conclude with the standard finishing message for all activities.
/// </summary>



class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
     "This activity will help you relax by guiding you through slow, deep breaths.")
    {
    }

    public void Run()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine("Press Enter to begin...");
        Console.ReadLine();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(5000);
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(6000);
            ShowCountDown(6);
        }

        Console.WriteLine("Well done! You have completed the Breathing Activity.");
        Menu();
    }

}