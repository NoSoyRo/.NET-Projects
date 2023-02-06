using System;

public class ReversedSentence
{
	public string sentencereversed(string str)
	{
        string[] strings = str.Split(' ');
		Console.WriteLine(strings);
	}
    static void Main(string[] args)
    {
        ReversedSentence je = new ReversedSentence();
        Console.WriteLine(je.sentencereversed("anita lava la tina"));
    }
}
