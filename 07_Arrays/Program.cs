
string city = "Istanbul";
string city2 = "Ankara";

Console.WriteLine(city);
Console.WriteLine(city2);


// STRING ARRAY

string[] cities = new string[3];
cities[0] = "İzmir";
cities[1] = "Bursa";
cities[2] = "Isparta";

string[] cities2 = { "Adana", "Trabzon", "Mersin" };

Console.WriteLine("*****************");
for (int i = 0; i < cities.Count(); i++)
    Console.WriteLine(cities[i]);

Console.WriteLine("*****************");
for (int i = 0; i < cities2.Count(); i++)
    Console.WriteLine(cities2[i]);


Console.ReadLine();