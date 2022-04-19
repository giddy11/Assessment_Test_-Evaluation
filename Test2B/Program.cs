// See https://aka.ms/new-console-template for more information

Console.Write("Enter a string: ");
string stringOfWords = Console.ReadLine();

static void CheckNumberofNumericAndText(string stringOfWords)
{
    int sumOfNumeric = 0;
    int sumOfText = 0;

    for (int i = 0; i < stringOfWords.Length; i++)
    {
        int countOfNumeric = 0;
        int countOfText = 0;

        if (stringOfWords[i] >= 48 && stringOfWords[i] <= 57)
        {
            countOfNumeric++;
            sumOfNumeric += countOfNumeric;
        }
        else
        {
            countOfText++;
            sumOfText += countOfText;
        }
    }
    Console.WriteLine($"It has {sumOfNumeric} number of numeric characters and {sumOfText} number of text characters");
}

CheckNumberofNumericAndText(stringOfWords);