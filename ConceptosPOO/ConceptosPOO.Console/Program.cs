using ConceptosPOO.Core;

try
{ 
    var date1 = new Date(30, 2, 2026);
    var date2 = new Date(29, 2, 2024);

    Console.WriteLine(date1.ToString());
    Console.WriteLine(date2.ToString());

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");

}
