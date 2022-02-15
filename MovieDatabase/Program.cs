
Console.WriteLine("Welcome to the Movie List Application!");

Dictionary<string, string> menu = new Dictionary<string, string>()
{
    ["The Lion King"] = "animated",
    ["Insidious"] = "horror",
    ["Spider-Man"] = "action", 
    ["No Time To Die"] = "action", 
    ["Ready Player One"] = "scifi",
    ["Dune"] = "scifi",
    ["Godzilla"] = "scifi",
    ["The Conjuring"] = "horror",
    ["Annabelle"] = "horror",
    ["Transformers"] = "scifi",
    ["Thor"] = "action",
    ["The Woman in Black"] = "horror",
    ["X-men"] = "action",
    ["The Hunger Games"] = "action",
    ["Spirited Away"] = "animated"

};

List<string> Movies = new List<string>();
bool runProgram = true;
while (runProgram)
{
    foreach (KeyValuePair<string, string> item in menu.OrderBy(item => item.Key))
    {
        Console.WriteLine(string.Format("{0,-55} {1,20}", item.Key, item.Value));
    }

    Console.WriteLine("There are 15 movies in this list.");
    Console.WriteLine("What categories are you interested in? ");
    string choice = Console.ReadLine();

    if (choice == "horror")
    {
        Console.WriteLine("Insidious, The Conjuring, Annabelle, The Woman in Black");
    }
    else if (choice == "animated")
    {
        Console.WriteLine("The Lion King, Spirited Away");
    }
    else if (choice == "scifi")
    {
        Console.WriteLine("Ready Player One, Dune, Godzilla, Transformers,");
    }
    else if (choice == "action")
    {
        Console.WriteLine("Spider-Man, No Time To Die, Thor, X-Men, The Hunger Games");
    }
    else
    {
        Console.WriteLine("That category does not exist in our database.");
    }

    Console.WriteLine("Continue? y/n");
        string loopChoice = Console.ReadLine();

    //string[] Category = new string { "horror, scifi, action, animated" };


    if (loopChoice == "y")
        {
            runProgram = true;
            break;
        }
        else if (loopChoice == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }

