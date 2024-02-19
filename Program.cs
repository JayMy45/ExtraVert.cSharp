// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

List<Plant> plants = new List<Plant>()
{
new Plant { Species = "Monstera", LightNeeds = 2, AskingPrice = 50.00M, City = "Seattle", ZIP = 37209, Sold = false },
new Plant { Species = "Peace Lily", LightNeeds = 1, AskingPrice = 30.00M, City = "Seattle", ZIP = 37201, Sold = true },
new Plant { Species = "Fiddle Leaf Fig", LightNeeds = 5, AskingPrice = 75.00M, City = "Seattle", ZIP = 37201, Sold = false },
new Plant { Species = "Snake Plant", LightNeeds = 1, AskingPrice = 25.00M, City = "Seattle", ZIP = 37209, Sold = false },
new Plant { Species = "Pothos", LightNeeds = 1, AskingPrice = 20.00M, City = "Seattle", ZIP = 37201, Sold = false },
};

string greeting = @$"Welcome to ExtraVert!
Here is a list of our plants:";

Console.Clear();
Console.WriteLine(greeting);

string? choice = null;

while (choice != "e")
{
    Console.WriteLine(@$"Select an option:
    a. Display all Plants
    b. Post a plant to be adopted
    c. Adopt a plant
    d. Delist a plant
    e. Exit");

    choice = Console.ReadLine();
    Console.WriteLine(@$"Press any key to continue...");
    Console.ReadKey();

    // used try block to handle choice logic and catch block to handle exception
    try
    {
        switch (choice)
        {
            //added NotImplementedException to the case "a" to handle the exception
            case "a" or "A":
                AllPlants();
                break;

            case "b" or "B":
                PostPlant();
                break;

            case "c" or "C":

                AdoptPlant();
                break;

            case "d" or "D":
                DelistPlant();
                break;

            case "e" or "E":

                ExitMenu();
                break;

            //!added default case to handle invalid choice
            default:
                Console.Clear();
                Console.WriteLine(@$"Invalid Choice: {choice}
Please select an option below 
                ");
                break;
        }
    }

    // Used catch block to handle NotImplementedException
    catch (NotImplementedException ex)
    {
        Console.WriteLine(ex.Message);
    }

}

void AllPlants()
{
    // TODO: Implement feature to display all plants.
    Console.Clear();
    throw new NotImplementedException("Display all plants \n");
}

void PostPlant()
{
    // TODO: Implement feature to post a plant for adoption.
    Console.Clear();
    throw new NotImplementedException("Post a plant to be adopted \n");
}

void AdoptPlant()
{
    // TODO: Implement feature to adopt a plant.
    Console.Clear();
    throw new NotImplementedException("Adopt a plant \n");
}

void DelistPlant()
{
    // TODO: Implement feature to delist a plant.
    Console.Clear();
    throw new NotImplementedException("Delist a plant \n");
}

void ExitMenu()
{
    Console.Clear(); // Clears the console
    Console.WriteLine("Exiting in 3 seconds...");
    Thread.Sleep(3000); // Wait for 3000 milliseconds (3 seconds)
    Console.Clear(); // Clears the console
}
