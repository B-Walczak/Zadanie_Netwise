using System.IO;
namespace Zadanie_Netwise.Components.Services;
public class FactStorageService
{

    private readonly string _filePath = "fakty_o_kotach.txt";

    public async Task SaveFactAsync(string factText)
    {
        int nextNumber = 1;

        if (File.Exists(_filePath))
        {
            var lines = await File.ReadAllLinesAsync(_filePath);
            nextNumber = lines.Length + 1;
        }

        string lineToSave = $"Fact nr {nextNumber}: {factText}\n";

        await File.AppendAllTextAsync(_filePath, lineToSave);
    }

    public async Task<List<string>> GetAllFactsAsync()
    {
        if (File.Exists(_filePath))
        {
            var lines = await File.ReadAllLinesAsync(_filePath);
            return lines.ToList();
        }

        return new List<string>();
    }

    public Task ClearAllFactsAsync()
    {
        if (File.Exists(_filePath))
        {
            File.Delete(_filePath);
        }
        return Task.CompletedTask;
    }
}