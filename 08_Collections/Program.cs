
// LIST

List<string> cities = new List<string>();

cities.Add("Istanbul");
cities.Add("Ankara");
cities.Add("Mardin");
cities.Add("Isparta");
cities.Add("Kocaeli");
cities.Add("Rize");
for (int i = 0; i < cities.Count(); i++)
{
    Console.WriteLine(cities[i]);
}

// METHOD OF LIST

cities.Clear();
Console.WriteLine("******** list cleared ********");

cities.Add("İzmir");

List<string> inputList = new List<string>()
{
    "Isparta",
    "Antalya",
    "Manisa",
    "Antalya",
    "Manisa"
};

cities.AddRange(inputList);


Console.WriteLine($"Count: {cities.Count()}");
cities.Insert(2,"Burdur");


for (int i = 0; i < cities.Count(); i++)
    Console.WriteLine(cities[i]);
Console.ReadLine();