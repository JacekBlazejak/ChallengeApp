int number = 122231;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

int caunter0 = 0;
int caunter1 = 0;
int caunter2 = 0;
int caunter3 = 0;
int caunter4 = 0;
int caunter5 = 0;
int caunter6 = 0;
int caunter7 = 0;
int caunter8 = 0;
int caunter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        caunter0++;
    }
    else if (letter == '1')
    {
        caunter1++;
    }
    else if (letter == '2')
    {
        caunter2++;
    }
    else if (letter == '3')
    {
        caunter3++;
    }
    else if (letter == '4')
    {
        caunter4++;
    }
    else if (letter == '5')
    {
        caunter5++;
    }
    else if (letter == '6')
    {
        caunter6++;
    }
    else if (letter == '7')
    {
        caunter7++;
    }
    else if (letter == '8')
    {
        caunter8++;
    }
    else if (letter == '9')
    {
        caunter9++;
    }
}

Console.WriteLine($"0: {caunter0}");
Console.WriteLine($"1: {caunter1}");
Console.WriteLine($"2: {caunter2}");
Console.WriteLine($"3: {caunter3}");
Console.WriteLine($"4: {caunter4}");
Console.WriteLine($"5: {caunter5}");
Console.WriteLine($"6: {caunter6}");
Console.WriteLine($"7: {caunter7}");
Console.WriteLine($"8: {caunter8}");
Console.WriteLine($"9: {caunter9}");