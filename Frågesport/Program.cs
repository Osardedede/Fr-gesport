using System;
using System.Threading;

int p = 0;
string name;
string minister;
string soldiers;
Console.WriteLine("Welcome to \"THE BRAIN IN THE BIN\" ");
Console.WriteLine("now who do we have with us today?");
name = Console.ReadLine();
Console.WriteLine($"Ok {name} lets get started");
Console.WriteLine("Wich swedish prime minister got murderd?");
Console.WriteLine($"Was it A, Olof Palme, B, Stefan löfven or C, Fredrik Rhainfelt");
minister = Console.ReadLine();
minister = minister.ToLower();
if (minister == "A")
{
    p = +1;
    Console.WriteLine("That is");
    Thread.Sleep(3000);
    Console.WriteLine($"THAT IS RIGHT now you have {p} point" );
}
else {
    Console.WriteLine("That is");
    Thread.Sleep(2000);
    Console.WriteLine($"WRONG, you are still at {p} points");

}

Console.WriteLine($"Now {name} we are going to go to question 2");
Console.WriteLine("How many soldiers did Sweden have at the end of ww2?");
Console.WriteLine("is it A,500 000 soldiers, B, 250 000 soldiers or C, 1 000 000 soldiers");
soldiers = Console.ReadLine();

if (soldiers == "C"){
    
}


Console.ReadLine();



