using System;
using System.IO;

public class Class1
{
	public Class1()
	{
		string path = "C:\Users\rodri\Documents\C#\OtrosExamenes\prueba.txt";
		using (StreamReader sr = File.OpenText(path))
        {
			string s;
			while ((s = sr.ReadLine()) != null)
            {
				Console.WriteLine(s);
            }
        }
	}
	static void Main(string[] args)
    {
		Class1 clase = new Class1();
    }
}
