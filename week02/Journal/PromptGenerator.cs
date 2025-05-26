using System;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What did you learn today?",
        "What was the best part of your day?",
        "What challenges did you face today?",
        "What are you grateful for today?",
        "What goals do you have for tomorrow?",
        "Describe a moment that made you smile today.",
        "What is something new you tried today?",
        "How did you help someone today?",
        "What is a lesson you learned from a mistake today?",
        "What are your thoughts on today's events?"
    };

    private Random _random = new Random();
    
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }   
}