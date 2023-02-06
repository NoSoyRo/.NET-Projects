using System;

public class Ordenamiento
{
	public int[] quickSort(int[] arr)
	{
		bool ordered = false;
        while (!ordered)
        {
			for (int i = 0; i < arr.length ; i++)
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
	}
	static void main(string[] args)
    {
		Ordenamiento ord = new Ordenamiento();
		int[] arr = { 1, 3, 2 };
		ord.quickSort(arr);
    }
}
