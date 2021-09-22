using System;
using System.Threading;
string game = "dewd";
static void spelet()
{

    string restart = "yes";

    while (restart == "yes")
    {
        int p = 0;
        string name;
        string soldiers = "w";
        string kim = "w";
        string minister = "w";



        Console.WriteLine("Welcome to \"THE BRAIN IN THE BIN\" ");
        Console.WriteLine("now who do we have with us today?");
        name = Console.ReadLine();
        Console.WriteLine($"Ok {name} lets get started");
        while (minister != "a" && minister != "b" && minister != "c")
        {

            Console.WriteLine("Wich swedish prime minister got murderd?");
            Console.WriteLine($"Was it A, Olof Palme, B, Stefan löfven or C, Fredrik Rhainfelt");
            minister = Console.ReadLine();
        }
        minister = minister.ToLower();



        if (minister == "a")
        {
            p += 1;
            Console.WriteLine("That is");
            Thread.Sleep(3000);
            Console.WriteLine($"THAT IS RIGHT now you have {p} point");
        }
        else if (minister == "b" || minister == "c")
        {
            Console.WriteLine("That is");
            Thread.Sleep(2000);
            Console.WriteLine($"WRONG, you are still at {p} points");
        }

        Console.WriteLine($"Now {name} we are going to go to question 2");
        while (soldiers != "a" && soldiers != "b" && soldiers != "c")
        {
            Console.WriteLine("How many soldiers did Sweden have at the end of ww2?");
            Console.WriteLine("is it A,500 000 soldiers, B, 250 000 soldiers or C, 1 000 000 soldiers");
            soldiers = Console.ReadLine();
        }
        soldiers = soldiers.ToLower();

        if (soldiers == "c")
        {
            p++;
            Console.WriteLine("Damn you are a smart one!");
            Console.WriteLine($"now you have {p} points!");
        }
        else if (soldiers == "a" || soldiers == "b")
        {

            Console.WriteLine("You proberly need to go back to kindergarden!");
            Console.WriteLine($"You are only at {p} points!");
        }


        Console.WriteLine("For the last question!");
        while (kim != "a" && kim != "b" && kim != "c")
        {
            Console.WriteLine("Now Who is the leader of North Korea");
            Console.WriteLine("A, Kim Jong-il B,Kim Jong-nam C,Kim Jong-un?");
            kim = Console.ReadLine();
        }
        kim = kim.ToLower();

        if (kim == "c")
        {
            p++;
            Console.WriteLine($"WOW that's so cool you are so good. Now you have {p} points");
        }
        else
        {
            Console.WriteLine($"You realy are garbage.... that was so easy. You only have {p} points");
        }


        if (p < 3)
        {
            Console.WriteLine($"Well {name} You were so garbage that you lost the hole game");
            Thread.Sleep(2000);
            Console.WriteLine("Now you dead");
            Console.WriteLine(@"  ___          
            /   \\        
       /\\ | . . \\       
     ////\\|     ||       
   ////   \\ ___//\       
  ///      \\      \      
 ///       |\\      |     
//         | \\  \   \    
/          |  \\  \   \   
           |   \\ /   /   
           |    \/   /    
           |     \\/|     
           |      \\|     
           |       \\     
           |        |     
           |_________\   ");
            Console.WriteLine("would you like to play again, Yes or No");
            restart = Console.ReadLine();
            restart = restart.ToLower();

        }

        if (p == 3)
        {
            Console.WriteLine("Congratulation now you win!");
            Console.WriteLine("You get YOUR OWN UNICORN");
            Console.WriteLine(@"|))    |))
 .             |  )) /   ))
 \\   ^ ^      |    /      ))
  \\(((  )))   |   /        ))
   / G    )))  |  /        ))
  |o  _)   ))) | /       )))
   --' |     ))`/      )))
    ___|              )))
   / __\             ))))`()))
  /\@   /             `(())))
  \/   /  /`_______/\   \  ))))
       | |          \ \  |  )))
       | |           | | |   )))
       |_@           |_|_@    ))
      /_/           /_/_/");
            Console.WriteLine("would you like to play again, Yes or No");
            restart = Console.ReadLine();
            restart = restart.ToLower();


        }
    }


    Console.ReadLine();
}

while (game != "yes" && game != "no")
{
    Console.WriteLine("do you want to play a game?");
    game = Console.ReadLine();
    if (game == "yes")
    {
        spelet();
    }
    if (game == "no")
    {
        Console.WriteLine("fuck you");
        Console.ReadLine();
    }

}