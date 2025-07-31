
/// </summary>
///   1.  The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
///   2.  The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
///   3.  After the starting message, select a random prompt to show the user such as:
///   
///   Who are people that you appreciate?
///   What are personal strengths of yours?
///   Who are people that you have helped this week?
///   When have you felt the Holy Ghost this month?
///   Who are some of your personal heroes?
///   4.  After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
///   5.  The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
///   6.  The activity them displays back the number of items that were entered.
///   7.  The activity should conclude with the standard finishing message for all activities.
/// <summary>


class ListingActivity : Activity
{
    private List<string> _answers;
    public ListingActivity() : base("Listing Activity", "List things you are grateful for")
    {
        _answers = new List<string>();  // Initialize the list!
    }

    public  void Run()
    {
         DisplayStartingMessage();
        int duration = GetDuration();
        _duration = duration;

        ShowSpinner(3);

        GetRandomPrompt();
        ShowCountDown(5);

        GetListFromUser();
        ShowSpinner(3);
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        string[] prompts = {
            "What made you smile today?",
            "What is something you learned recently?",
            "Who is someone you appreciate?",
            "What is a favorite memory?",
            "What is something you are looking forward to?"
        };
        //check to make sure you don't repeat the same prompts
        HashSet<string> usedPrompts = new HashSet<string>();
        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
        string response = Console.ReadLine();
        _answers.Add(response);
    }

    public void GetListFromUser()
    {
        // print the current list of answers
        Console.WriteLine("Your current list of items:");
        foreach (var item in _answers)
        {
            Console.WriteLine($"- {item}");
        }
    }
    


}