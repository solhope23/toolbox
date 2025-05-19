using System;

abstract public class tool
{
    protected string Name;
    protected double Weight;

    public tool(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    abstract public void Describe();

    public void Use()
    {
        Console.WriteLine(Name + " is being used.");
    }
}