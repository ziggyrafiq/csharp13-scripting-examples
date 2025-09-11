try
{
    Console.WriteLine("Processing...");
    int result = 10 / int.Parse("0");  // Intentional divide-by-zero
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Cleanup done.");
}