using System.IO;


String input;
try
{
    StreamReader sr = new StreamReader("input.txt");

    int total = 0;
    input = sr.ReadToEnd();
    input = new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
    char[] chars = input.ToLower().ToCharArray();

    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] == ' ')
            if (chars[i - 1] == 't' || chars[i - 1] == 'e')
                total++;
    }    

    Console.WriteLine("There are " + total + " words that end in t and e"); 
    
    sr.Close();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
