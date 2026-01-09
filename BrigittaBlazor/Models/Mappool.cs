using MudBlazor;

namespace BrigittaBlazor.Models;

public class Mappick
{
    public string Abbreviation { get; set; } = "";
    public int ModComb { get; set; }
    public int MapId { get; set; }

    public Mappick() { }

    public Mappick(string abbreviation, int modComb, int mapId)
    {
        Abbreviation = abbreviation;
        ModComb = modComb;
        MapId = mapId;
    }

    public Color GetColor()
        => (Abbreviation[..2]) switch 
        { 
            "NM" => Color.Info,
            "HD" => Color.Warning,
            "HR" => Color.Error,
            "DT" => Color.Primary,
            "FM" => Color.Success,
            "TB" => Color.Warning,
            _ => Color.Info
        };
}

public class Mappool
{
    public string TourAbbr { get; set; } = "";
    public List<Mappick> Mappicks = [];
}