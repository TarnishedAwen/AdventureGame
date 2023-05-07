using System;

public class Task
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public Item Reward { get; set; }

    public Task(string description, Item reward)
    {
        Description = description;
        Reward = reward;
        IsCompleted = false;
    }
}