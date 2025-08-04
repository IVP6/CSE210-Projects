



class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    //display
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting activity: {_name}");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
    }
    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
   
   
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(2);
    }
    // Removed duplicate ShowSpinner method to resolve ambiguity
    // Duplicate ShowCountDown method removed to resolve ambiguity



    public static void Menu()
    {
        Console.WriteLine("Welcome to the Mindfulness Project!");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                // Start Breathing Activity
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();

                break;
            case "2":
                // Start Reflecting Activity
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();

                break;
            case "3":
                // Start Listing Activity
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();

                break;
            case "4":
                Console.WriteLine("Exiting the program.");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Menu();
                break;
        }
    } 
}