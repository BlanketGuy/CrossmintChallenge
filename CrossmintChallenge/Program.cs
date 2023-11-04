using CrossmintChallenge;
using CrossmintChallenge.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

internal class Program
{
    private static async Task Main()
    {
        try
        {
            Megaverse megaverse = new();
            JsonSerializerOptions options = new(JsonSerializerDefaults.Web);
            megaverse = JsonSerializer.Deserialize<Megaverse>(await megaverse.GetMetaverseGoal(), options);

            // Calling the solution for the necessary phase
            await PhaseTwo.Solution(megaverse);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}