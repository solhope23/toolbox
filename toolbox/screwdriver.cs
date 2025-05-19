using System;

public class screwdriver : tool
{
    public screwdriver() : base("screwdriver", 0.3)
    {
    }

    public override void Describe()
    {
        Console.WriteLine("The tool is called a screwdriver and it weighs less than half a kilo.");
    }
}