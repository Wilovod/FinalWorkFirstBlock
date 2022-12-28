Console.Clear();
string[] arrOne = {"hello","2","world",":-)"};
string[] arrTwo = new string[arrOne.Length-1];
int j = 0;

for (int i=0; i< arrOne.Length;i++)
{
    if (arrOne[i].Length <= 3)
    {
        arrTwo[j] = arrOne[i];
        Console.WriteLine(arrTwo[j]);
        j++;
    }
}



