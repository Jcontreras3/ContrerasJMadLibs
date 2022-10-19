//Jovann Contreras
//Date 10/19/2022
//Having multiple options for users to type in so that they can create a story.

string retry = "yes";
while (retry == "yes")
{
    String adj, fictionalCreature, specialEvent, adjTwo, heOrshe, adverb, location, noun, color, food;

    Console.WriteLine("Create your story");
    Console.WriteLine("Enter in a adjective");
    adj = Console.ReadLine();
    Console.WriteLine("Enter in a fictional creature");
    fictionalCreature = Console.ReadLine();
    Console.WriteLine("Enter in a special event");
    specialEvent = Console.ReadLine();
    Console.WriteLine("Enter in a adjTwo");
    adjTwo = Console.ReadLine();
    Console.WriteLine("Enter in a He or She");
    heOrshe = Console.ReadLine();
    Console.WriteLine("Enter in a adverb");
    adverb = Console.ReadLine();
    Console.WriteLine("Enter in a location");
    location = Console.ReadLine();
    Console.WriteLine("Enter in a noun");
    noun = Console.ReadLine();
    Console.WriteLine("Enter in a color");
    color = Console.ReadLine();
    Console.WriteLine("Enter in a food");
    food = Console.ReadLine();

    Console.WriteLine($"The {adj} day was a hard day for {fictionalCreature}, {heOrshe} got up to go to a {specialEvent} at the {location} but {heOrshe} had to go and get {food}. Walking down the side walk {heOrshe} had seen their favorite {noun} in their favorite {color}. Continuing on {heOrshe} made it down to the {adjTwo} resturant they {adverb} inside and grabbed the food. {heOrshe} made it to the {specialEvent} and was happy The End. ");

    Console.Write("Would you like to try again? Type in Yes to retry or No to quit: ");

    string playAgainInput = "";
    while (playAgainInput != "yes" || playAgainInput != "no")
    {
        playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == retry)
        {
            break;
        }
        else if (playAgainInput == "no")
        {
            Console.WriteLine("Thanks for playing!");
            retry = playAgainInput;
            break;
            
        }
        else
        {
            Console.WriteLine("Invalid Input");
            playAgainInput = "invalid";
        }


    }
}
