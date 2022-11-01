int[] ints = new int[] {1,0,0,0,0};
bool NotNinesOnly = false;
bool outOfRange = false;
int j = 1;

for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] < 0 || ints[i] > 9)
    {
        outOfRange = true;
    }
    if (ints[i] != 9)
    {
        NotNinesOnly = true;
    }
}
if (outOfRange)
{
    Console.WriteLine("invalid value");
}
else if (NotNinesOnly)
{
    while (ints[ints.Length - j] == 9)
    {
        ints[ints.Length - j] = 0; j++;
    }
    ints[ints.Length - j]++;
    foreach (int intss in ints)
    {
        Console.Write(intss);
    }
}
else
{
    int[] ints1 = new int[ints.Length + 1];
    ints1[0] = 1;
    foreach (int intss in ints1)
    {
        Console.Write(intss);
    }
}
