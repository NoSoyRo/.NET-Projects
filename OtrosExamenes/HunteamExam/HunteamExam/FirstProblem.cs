using System;
using System.IO;

public class Class1
{
	public Class1()
	{
		string path = "C:\\Users\\rodri\\Documents\\C#\\OtrosExamenes\\prueba.txt";
		using (StreamReader sr = File.OpenText(path))
		{
			string s;
			string t = "";
			while ((s = sr.ReadLine()) != null) 
			{
				t = t + s;
			}
			double max = 0;
			int indice_inicio = 0;
			for (int i = 0; i < t.Length-14 ; i++)
            {
				double mult = int.Parse(t[i].ToString())*int.Parse(t[i+1].ToString())*int.Parse(t[i+2].ToString())*int.Parse(t[i+3].ToString())*int.Parse(t[i+4].ToString())*int.Parse(t[i+5].ToString())*int.Parse(t[i+6].ToString())*int.Parse(t[i+7].ToString())*int.Parse(t[i+8].ToString())*int.Parse(t[i+9].ToString())*int.Parse(t[i+10].ToString())*int.Parse(t[i+11].ToString())*int.Parse(t[i+12].ToString());
				if (mult > max)
                {
					max = mult;
					indice_inicio = i;
                }
            }
			Console.WriteLine(max);
			Console.WriteLine(t[indice_inicio]);
			Console.WriteLine(t[indice_inicio+1]);
			Console.WriteLine(t[indice_inicio+2]);
			Console.WriteLine(t[indice_inicio+3]);
			Console.WriteLine(t[indice_inicio+4]);
			Console.WriteLine(t[indice_inicio+5]);
			Console.WriteLine(t[indice_inicio+6]);
			Console.WriteLine(t[indice_inicio+7]);
			Console.WriteLine(t[indice_inicio+8]);
			Console.WriteLine(t[indice_inicio+9]);
			Console.WriteLine(t[indice_inicio+10]);
			Console.WriteLine(t[indice_inicio+11]);
			Console.WriteLine(t[indice_inicio+12]);
			Console.WriteLine(t[indice_inicio+13]);
			Console.WriteLine(indice_inicio);
		}
	}
	static void Main(string[] args)
	{
		Class1 clase = new Class1();
	}
}