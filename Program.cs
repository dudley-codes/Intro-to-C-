using System;

Console.Write("First Name > ");
string firstName = Console.ReadLine();

Console.Write("Last Name > ");
string lastName = Console.ReadLine();

string reverse = string.Empty;

string fullName = firstName + " " + lastName;

for (int num = fullName.Length - 1; num >= 0; num--)
{
    reverse = reverse + fullName[num];
}

Console.WriteLine(reverse);
