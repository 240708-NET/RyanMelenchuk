using BlackjackData.Models;
using System.Text.Json;

namespace BlackjackData.Repo;

// This is the only class allowed to read/write to the saved file(s)
public class Serialization : IRepository
{

    public void StreamReaderReadLine(string path)
    {

    }

    public void StreamReaderWriteLine(string path)
    {

    }

    public void SaveChips(int chips)
    {
        int serChips = JsonSerializer.Serialize(chips);
        Console.WriteLine("chips serialized");
    }

    public void SaveWLRatio()
    {

    }
}