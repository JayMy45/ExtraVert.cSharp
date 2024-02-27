// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

List<Plant> plants = new List<Plant>()
{
new Plant { Species = "Monstera", LightNeeds = 2, AskingPrice = 50.00M, City = "Nashville, TN", ZIP = 37209, Sold = false },
new Plant { Species = "Peace Lily", LightNeeds = 1, AskingPrice = 30.00M, City = "Knoxville, TN", ZIP = 37201, Sold = true },
new Plant { Species = "Fiddle Leaf Fig", LightNeeds = 5, AskingPrice = 75.00M, City = "Memphis, TN", ZIP = 37201, Sold = false },
new Plant { Species = "Snake Plant", LightNeeds = 1, AskingPrice = 25.00M, City = "Lebanon, TN", ZIP = 37209, Sold = false },
new Plant { Species = "Pothos", LightNeeds = 1, AskingPrice = 20.00M, City = "Asheville, TN", ZIP = 37201, Sold = false },
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
    Console.WriteLine($"\n Press any key to continue...");
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
    Console.Clear();
    // TODO: Implement feature to display all plants.
    //list all plants 1 per line
    /*
    <Number>. <Name of Plant> in <City> <is available/was sold> for <Price> dollars
        Examples: 
        1. Ficus in Pasadena was sold for 15 dollars
        2. Hydrangea in Walla Walla is available for 25 dollars
    */
    Console.WriteLine("All Plants: \n");

    for (int i = 0; i < plants.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {plants[i].Species} in {plants[i].City} {(plants[i].Sold ? "was sold for" : "is available for")} {plants[i].AskingPrice:C} dollars");
    }
    Console.WriteLine("\n");
}

void PostPlant()
{
    Console.Clear();
    /*
            - user input for plant details using Console.ReadLine();
                string  - Species = "Monstera", 
                int     - LightNeeds = 2, 
                decimal - AskingPrice = 50.00M, 
                string  - City = "Seattle", 
                int     - ZIP = 37209, 
                bool    - Sold = false
            - after all details are entered, add the plant to the list of plants
            - add() method to add a plant to the list of plants
    */
    // TODO: Implement feature to post a plant for adoption.
    string? species = null;
    int lights = 0;
    decimal price = 0;
    string? city = null;
    int zipCode = 0;


    Console.WriteLine("Enter the plant species:");
    species = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("Enter the light needs: 1-5: 1 being low, 5 being high:");

    lights = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Enter the asking price:");
    price = decimal.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Enter the city:");
    city = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("Enter the ZIP code:");
    zipCode = int.Parse(Console.ReadLine());

    Plant newPlant = new Plant { Species = species, LightNeeds = lights, AskingPrice = price, City = city, ZIP = zipCode, Sold = false };


    // Console.WriteLine("Has the plant been sold? True or False:");
    // Sold = Console.ReadLine();
    Console.Clear();
    Console.WriteLine(newPlant);
    Console.WriteLine($"\n Press any key to continue to post new plant...");
    Console.ReadKey();

    plants.Add(newPlant);
    Console.Clear();
    Console.WriteLine("Plant added successfully!");

}

void AdoptPlant()
{
    // TODO: Implement feature to adopt a plant.
    /*
    Provide a list of plants that are available for adoption
        - create a list of available plants
        - use foreach loop to iterate through the list of plants
        - add plants that are not sold to the list of available plants List<Plant> availablePlants
        - display the list of available plants
        - user input for plant to adopt using Console.ReadLine();
        - change Sold to true
        - display a message that the plant has been adopted
    */

    List<Plant> availablePlants = new List<Plant>();

    Console.Clear();
    Console.WriteLine("Here is a list of Available Plants: \n");

    //   List<Plant> availablePlants = plants.Where(plant => plant.Sold == false).ToList();
    foreach (Plant plant in plants)
    {
        if (plant.Sold == false)
        {
            availablePlants.Add(plant);
        }
    }

    for (int i = 0; i < availablePlants.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {availablePlants[i].Species}, Cost: {availablePlants[i].AskingPrice:C} ({availablePlants[i].City}).");
    }

    Console.Clear();

    Console.WriteLine("Enter the number of the plant you would like to adopt: \n");
    for (int i = 0; i < availablePlants.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {availablePlants[i].Species}, Cost: {availablePlants[i].AskingPrice:C} ({availablePlants[i].City}).");
    }

    try
    {
        int plantChoice = int.Parse(Console.ReadLine());
        availablePlants[plantChoice - 1].Sold = true;
        Console.Clear();
        Console.WriteLine($"{availablePlants[plantChoice - 1].Species} has been adopted!");
        Console.WriteLine($"\n Back to Main Menu... \n");
        Thread.Sleep(2000); // Wait for 2000 milliseconds (2 seconds)
        Console.Clear(); // Clears the console
    }
    catch (FormatException)
    {
        Console.WriteLine("Do Better pimpin");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Invalid input, please enter a number between 1 and 4: ");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


{


    // Console.Clear();
    // throw new NotImplementedException("Adopt a plant \n");
}

void DelistPlant()
{

    /*
        Provide a list of available plants
        Allow user to select a plant to delist via int and Console.ReadLine()
        remove plant from list using removeAt() method
        Display a message that the plant has been removed
        catch exceptions
    */
    // use AllPlant() to display all plants
    Console.Clear();
    Console.WriteLine("Enter the number of the plant you would like to REMOVE: \n");

    for (int i = 0; i < plants.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {plants[i].Species} in {plants[i].City} {(plants[i].Sold ? "was sold for" : "is available for")} {plants[i].AskingPrice:C} dollars");
    }
    Console.WriteLine("\n");

    try
    {
        int plantChoice = int.Parse(Console.ReadLine());
        // Store species name before removal for message display
        var removedSpecies = plants[plantChoice - 1].Species;
        plants.RemoveAt(plantChoice - 1);
        Console.Clear();
        Console.WriteLine($"{removedSpecies} has been removed...");
        Console.WriteLine($"\n Back to Main Menu... \n");
        Thread.Sleep(2000); // Wait for 2000 milliseconds (2 seconds)
        Console.Clear(); // Clears the console
    }
    catch (FormatException)
    {
        Console.WriteLine("Do Better pimpin");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine($"Invalid input, please enter a number between 1 and {plants.Count}: ");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    // TODO: Implement feature to delist a plant.
    // Console.Clear();
    // throw new NotImplementedException("Delist a plant \n");
}

void ExitMenu()
{
    Console.Clear(); // Clears the console
    Console.WriteLine("Exiting momentarily...");
    Thread.Sleep(2000); // Wait for 3000 milliseconds (3 seconds)
    Console.Clear(); // Clears the console
}