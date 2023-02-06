using System;

public class ReversedSentence
{
	public string Sentencereversed(string str)
	{
        string[] strings = str.Split(' ');
        string s = "";

        for (int i = 0, j = strings.Length-1; i < j; i++, j--)
        {
            string aux = strings[i];
            Console.WriteLine(strings[i]);
            Console.WriteLine(strings[j]);
            strings[i] = strings[j];
            Console.WriteLine(strings[i]);
            strings[j] = aux;
            Console.WriteLine(strings[j]);
        }

        for (int i = 0; i <= strings.Length-1; i++)
        {
            s = s+" "+strings[i];
            Console.WriteLine(s);
        }


        return s;

   	}
    static void Main(string[] args)
    {
        ReversedSentence je = new ReversedSentence();
        Console.WriteLine(je.Sentencereversed("anita lava la tina"));
    }
}
