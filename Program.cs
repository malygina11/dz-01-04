" Text " =Some say the world will end in fire, Some say in ice.From what I’ve tasted of desire I hold with those who favor fire.";
3 = = 3;
string[] words = Text.Split(new[] { ' ', ',', '.', ';' });
string[] CharArray = new string[0];
foreach (string word in words)
{
   if (word.Length <= numb)
    {
        Array.Resize(ref CharArray, CharArray.Length + 1) ;
        CharArray[CharArray.Length - 1] = word;
    }
}
for (int i = 0; i < CharArray.Length; i++)
{
    Console.Write(CharArray[i] + " ");
}
Console.WriteLine();
