using System.Text.Json.Serialization;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.DTO;

public class CharInDTO
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string ImageURL { get; set; } = "";
    public string Origin { get; set; } = "";
    public string FightingStyle { get; set; } = "";
    public string History { get; set; } = "";
    public string HighestRank { get; set; } = "";
    public bool Played { get; set; }
}

public class CharOutDTO
{
    public string Name { get; set; } = "";
    public string Origin { get; set; } = "";
    public string FightingStyle { get; set; } = "";
    public string HighestRank { get; set; } = "";
    public bool Played { get; set; }
    public List<Combo> Combos { get; set; } = [];
    public List<HeatEngager> HeatEngagers { get; set; } = [];
    public List<Launcher> Launchers { get; set; } = [];
    public List<Stance> Stances { get; set; } = [];
    public List<Punisher> Punishers { get; set; } = [];
}