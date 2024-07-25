using BlackjackData.Models;

namespace BlackjackData.Repo;

public interface IRepository
{
    void CreatePlayer(Player newPlayer);
    Player GetPlayerByID(int ID);
    int GetChips(Player player);
    List<Player> LoadAllPlayers();
    void UpdatePlayer(Player player);
    void DeletePlayerByID(int ID);

}
