namespace BlackjackData.Repo;

public interface IRepository
{
    public void StreamReaderReadLine(string path);
    public void StreamReaderWriteLine(string path);
    public void SaveChips(int chips);
    public void SaveWLRatio();
}
