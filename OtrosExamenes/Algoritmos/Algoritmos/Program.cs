using System;

public class Ordenamiento
{
	public int[] quickSort(int[] arr)
	{
		bool ordered = false;
		while (!ordered)
		{
			for (int i = 0; i < arr.Length-1; i++)
			{
				if (arr[i] > arr[i + 1])
				{
					int aux = arr[i];
					arr[i] = arr[i + 1];
					arr[i + 1] = aux;
					ordered = false;
					break;
				}
				else
				{
					ordered = true;
				}
			}
		}
		return arr;
	}
	static void Main(string[] args)
	{
		Ordenamiento ord = new Ordenamiento();
		int[] arr = { 1, 3, 2,4,5,7,7,7,2,3,3,2,6,7,78,21 };
		int[] aux = arr;
		arr = ord.quickSort(arr);
		foreach (int i in arr)
        {
			Console.WriteLine(i.ToString());	
        }
		Console.WriteLine(aux.Length+" "+arr.Length);
	}
}
