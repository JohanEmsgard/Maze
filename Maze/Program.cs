﻿using System;

System.Console.WriteLine("Du är fast i ett rum och du behöver komma ute. Dörr A eller Dör B?");
Console.ReadLine();

string room = "A";

while (room != "ute")
{
    if (room == "A")
    {
        Console.WriteLine("Du är inne i rum A");
        Console.WriteLine("Rum C eller D?");
        string door = Console.ReadLine();
        if (door == "C")
        {
            room = "C";
        }
        else if (door == "D")
        {
            room = "D";
        }
    }


        if (room == "C")
        {
            Console.WriteLine("Du är i rum C");
            Console.WriteLine("Rum A eller G");
            room = Console.ReadLine();
        }

        else if (room == "D")
        {
            Console.WriteLine("Du är i rum D");
            Console.WriteLine("Rum A eller H");
            room = Console.ReadLine();
        }


    else if (room == "B")
    {
        Console.WriteLine("Du är i rum B");
        Console.WriteLine("Rum E eller F");
        room = Console.ReadLine();
    }


}

