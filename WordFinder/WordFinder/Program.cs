namespace WordFinder;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(WordFinder("the couch cat sat on the mat","cat"));
    }

    public static bool WordFinder(string myString, string myWord)
    {
        int i;
        for (i = 0; i < myString.Length; i++)
        {
            int j;
            for (j = 0; j < myWord.Length; j++)
            {
                if (myString[i+j] != myWord[j])
                {
                    break;
                }
            }
            if (j == myWord.Length)
            {
                return true;
            }
        }

        return false;
    }
}
