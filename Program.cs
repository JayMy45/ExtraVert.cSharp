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
    try
    {
        switch (choice)
        {
            case "a":
                // TODO: Implement feature to display all plants.
                throw new NotImplementedException("Display all plants");

            case "b":
                // TODO: Implement feature to post a plant for adoption.
                throw new NotImplementedException("Post a plant to be adopted");

            case "c":
                // TODO: Implement feature to adopt a plant.
                throw new NotImplementedException("Adopt a plant");

            case "d":
                // TODO: Implement feature to delist a plant.
                throw new NotImplementedException("Delist a plant");

            case "e":

                Console.WriteLine($"Exit");
                break;

            default:
                Console.WriteLine($"Invalid Choice: {choice}.");
                break;
        }
    }
    catch (NotImplementedException ex)
    {
        Console.WriteLine(ex.Message);
    }



}

