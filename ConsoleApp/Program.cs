// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

citiesList.Add("New York City");
      
citiesList.Remove("Delhi");
      
citiesList.AddRange(new string[] {"Cairo", "Johannesburg"});
      
bool hasNewDelhi = citiesList.Contains("New Delhi");

Console.WriteLine(hasNewDelhi);

foreach (var city in citiesList)
{
    Console.WriteLine(city);
}