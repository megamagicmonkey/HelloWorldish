using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I am the bridge keeper! Let us see if you are worthy to pass!");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            if (name != "No" && name != "I don't know"){
                Console.WriteLine("What is your favorite color?");
                var color = Console.ReadLine();
                if (color != "No" && color != "I don't know"){
                    Console.WriteLine("What is your quest?");
                    var quest = Console.ReadLine();
                    if (quest != "No" && quest != "I don't know"){
                        Console.WriteLine("So your name is " + name +", your favorite color is " + color + ", and your oh-so important quest is " + quest +"?");
                        Console.WriteLine("Are you sure?");
                        var certain = Console.ReadLine();
                        if (certain != "No" && certain != "N"){
                            Console.WriteLine("Hello Worl- Urk! I mean, you may pass, adventurer.");
                            
                        }
                        else{
                             Console.WriteLine("*you are flung into the abyss below the bridge*");
                        }
                    }
                    else{
                        Console.WriteLine("*you are flung into the abyss below the bridge*");
                    }
                }
                else{
                Console.WriteLine("*you are flung into the abyss below the bridge*");
                }
            }
            else{
                Console.WriteLine("*you are flung into the abyss below the bridge*");
            }
        }
    }
}
