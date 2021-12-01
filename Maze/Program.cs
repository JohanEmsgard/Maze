using System;

System.Console.WriteLine("Du är fast i ett rum och du behöver komma ute. Dörr A eller Dör B?");
Console.ReadLine();

string door ="A";

while(door != "ute")
{
    if (door == "A")
    {
        Console.WriteLine("Du är inne i rum A");
        door = Console.ReadLine();
        
    }

    else if (door == "B")
    {
        Console.WriteLine("Du är i rum B");
        door = Console.ReadLine();
    }
}

