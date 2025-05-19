using System;

public class hammer : tool
{
    public hammer() : base("hammer", 5)
    {
    }

    public override void Describe()
    {
        Console.WriteLine("The product is a hammer and it weighs 5 kilos and it is made to drive nails into wood.");
    }
}