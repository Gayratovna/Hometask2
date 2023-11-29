using Hometask2;

Month month = new Month();

Month currentMonth = Month.November;
Console.WriteLine(currentMonth.ToString());
for (int i = (int)currentMonth; i <= (int)Month.November; i++)
{
    Console.WriteLine("There is a month until November 2024 next year: " + i.ToString());
}

Month birthMonth = Month.February;

if (birthMonth != currentMonth)
{
    Console.WriteLine(birthMonth.ToString());
}


