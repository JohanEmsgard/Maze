using System;

System.Console.WriteLine("Du är fast i ett rum och du behöver komma ute. Dörr A eller Dör B?");
Console.ReadLine();

string door = "A";

while (door != "ute")
{
    if (door == "A")
    {
        Console.WriteLine("Du är inne i rum A");
        Console.WriteLine("Rum C eller D?");
        door = Console.ReadLine();
    }

        if (door == "C")
        {
            Console.WriteLine("Du är i rum C");
            Console.ReadLine();
        }

        else if (door == "D")
        {
            Console.WriteLine("Du är i rum D");
            door = Console.ReadLine();
        }


    else if (door == "B")
    {
        Console.WriteLine("Du är i rum B");
        door = Console.ReadLine();
    }
}

