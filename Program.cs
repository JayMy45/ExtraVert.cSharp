// See https://aka.ms/new-console-template for more information
List<Plant> plants = new List<Plant>()
{
new Plant { Species = "Monstera", LightNeeds = 2, AskingPrice = 50.00M, City = "Seattle", ZIP = 37209, Sold = false },
new Plant { Species = "Peace Lily", LightNeeds = 1, AskingPrice = 30.00M, City = "Seattle", ZIP = 37201, Sold = true },
new Plant { Species = "Fiddle Leaf Fig", LightNeeds = 5, AskingPrice = 75.00M, City = "Seattle", ZIP = 37201, Sold = false },
new Plant { Species = "Snake Plant", LightNeeds = 1, AskingPrice = 25.00M, City = "Seattle", ZIP = 37209, Sold = false },
new Plant { Species = "Pothos", LightNeeds = 1, AskingPrice = 20.00M, City = "Seattle", ZIP = 37201, Sold = false },
};

Console.WriteLine(@$"Welcome to ExtraVert!
Here is a list of our plants:");

for (int i = 0; i < plants.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plants[i].Species}");
}