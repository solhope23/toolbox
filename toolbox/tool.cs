using System;

abstract public class tool
{
    public string Name;
    public int Weight;

    public tool(string name, int weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    abstract public void Describe();

    public void Use()
    {
        Console.WriteLine(Name + "is being used");
    }
}