using System;

public class Palindrome
{
	public bool Verify(string str)
	{
        string aux = str;
        char[] charArray = str.ToCharArray();
        char[] charArray2 = charArray.();
        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            charArray[i] = str[j];
            charArray[j] = str[i];
        }
        string reversedstring = string(charArray):
        if (reversedstring == str)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        Verify("anita lava la tina")
    }
}
