using Hometask2;

Month month = new Month();
string[] name = Enum.GetNames(typeof(Month));
int[] number = (int[])Enum.GetValues(typeof(Month));

for (int i = 0; i <= number.Length; i++)
{
    if (DateTime.Now.Month <= number[i])
    {
        Console.WriteLine(name[i] + " " + DateTime.Now.Month + "-month");
    }
}

Console.WriteLine();

for (int i = 0; i <= 12; i++)
{
    Console.WriteLine(Enum.GetName(typeof(Month), i));
}

Console.WriteLine();



Month birthMonth = Month.February;

if (birthMonth != 0)
{
    Console.WriteLine(birthMonth.ToString());
}


