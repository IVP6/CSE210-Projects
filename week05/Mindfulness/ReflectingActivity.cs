using System;
using System.Collections.Generic;

/// <summary>
/// 1. The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
/// 2. The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
/// 3. After the starting message, select a random prompt to show the user such as:
///    Think of a time when you stood up for someone else.
///    Think of a time when you did something really difficult.
///    Think of a time when you helped someone in need.
///    Think of a time when you did something truly selfless.
/// 4. After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:
///    Why was this experience meaningful to you?
///    Have you ever done anything like this before?
///    How did you get started?
///    How did you feel when it was complete?
///    What made this time different than other times when you were not as successful?
///    What is your favorite thing about this experience?
///    What could you learn from this experience that applies to other situations?
///    What did you learn about yourself through this experience?
///    How can you keep this experience in mind in the future?
/// 5. After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
/// 6. It should continue showing random questions until it has reached the number of seconds the user specified for the duration.
/// 7. The activity should conclude with the standard finishing message for all activities.
/// </summary>



class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;
    protected List<string> _promptAnswers;
    protected List<string> _questionAnswers;

    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        GetDuration(); // Get the duration from the user
        Console.WriteLine("Let's begin with a prompt:");
        DisplayPrompt();
        Console.WriteLine("Now, let's reflect on some questions related to your experience.");
        DisplayQuestion();
        Console.WriteLine("When you are ready to answer, press enter to continue.");
        Console.ReadLine();


        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Answer: ");
            var input = Console.ReadLine();
            _promptAnswers.Add(input);
            // Simulate a pause with a countdown
            ShowCountDown(_duration); // Adjust the countdown duration as needed
        }

        DisplayEndingMessage();
        Menu(); // Call the static Menu method from Activity class
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
        var input2 = Console.ReadLine(); // Wait for user input to continue
        _questionAnswers.Add(input2);
    }





}