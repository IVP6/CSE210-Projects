using System;
using System.Collections.Generic;
using System.IO;





public class PromptGenerator
{
    public List<string> _prompts;
    private Random _random = new Random();
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "What's a lesson that came from a mistake you made today?",
            "In what ways are you different now than you were yesterday or this morning?",
            "What is one habbit you want to build, and what's the first step you can take to build it?",
            "Invent a character based on your day today, and write a short story about them.",
            "What is something you learned today that you want to remember?",
            "What does it mean to truly know yourself?",
            "What is something you want to do tomorrow that you didn't do today?",
            "What is something you are grateful for today?",

        };
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }



}