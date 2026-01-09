using BrigittaBlazor.Models;

namespace BrigittaBlazor.Utils;

public class LobbyManager
{
    /*
     * Manage timers and mappool (if exists) for each multiplayer lobby
     * More can be added later (if I even know what to add :D)
     */

    public LobbyManager()
    {
        LoadMappools();
    }
    
    // ------------------------------------------------------------------------------------
    // Timer Manager
    
    private readonly Dictionary<string, LobbyTimers> _timers = new();

    public LobbyTimers GetOrCreateTimers(string lobbyName)
    {
        if (!_timers.ContainsKey(lobbyName))
            _timers.Add(lobbyName, new LobbyTimers());
        return _timers[lobbyName];
    }
	
    public void DeleteLobbyTimers(string lobbyName)
    {
        _timers.Remove(lobbyName);
    }
    
    // ------------------------------------------------------------------------------------
    // Mappool Manager

    private readonly List<Mappool> _mappools = [];
    
    public void LoadMappools()
    {
        // Load mappools from Mappools.json
    }

    public Mappool? GetMappool(string tourAbbr)
    {
        foreach (var mappool in _mappools)
        {
            if (mappool.TourAbbr == tourAbbr)
                return mappool;
        }
        
#if DEBUG
        return new Mappool
        {
            TourAbbr = tourAbbr,
            Mappicks = [
                new Mappick("NM1", 1, 123456),
                new Mappick("NM2", 1, 123456),
                new Mappick("NM3", 1, 123456),
                new Mappick("NM4", 1, 123456),
                new Mappick("NM5", 1, 123456),
                new Mappick("HD1", 9, 123456),
                new Mappick("HD2", 9, 123456),
                new Mappick("HR1", 17, 123456),
                new Mappick("HR2", 17, 123456),
                new Mappick("DT1", 65, 123456),
                new Mappick("DT2", 65, 123456),
                new Mappick("DT3", 65, 123456),
            ]
        };
#endif
        return null;
    }
    
    public void ParseMappool(string rawData)
    {
        SaveMappools();
    }

    public void UpdateMappool(Mappool mappool)
    {
        SaveMappools();
    }
    
    public void RemoveMappool(string tourAbbr)
    {
        foreach (var mappool in _mappools)
        {
            if (mappool.TourAbbr != tourAbbr) continue;
            _mappools.Remove(mappool);
            break;
        }

        SaveMappools();
    }

    private void SaveMappools()
    {
        /* Called in every CURD operation
         * but shouldn't be a problem, not that it's a problem anyway
         * this app scale isn't that big
         */
    }
}