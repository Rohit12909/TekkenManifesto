namespace tekkenManifesto.API.Model;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string ImageURL { get; set; } = "";
    public string Origin { get; set; } = "";
    public string FightingStyle { get; set; } = "";
    public string History { get; set; } = "";
    public string HighestRank { get; set; } = "";
    public bool Played { get; set; }

    public List<Combo> Combos { get; set; } = [];
    
    // Heat Engagers [Input, Frames On Block]
    public List<HeatEngager> HeatEngagers { get; set; } = [];

    // Launchers [Input, Frames On Block]
    public List<Launcher> Launchers { get; set; } = [];
    
    // Stances [Name, Input]
    public List<Stance> Stances { get; set; } = [];
    
    // Punishers [Input, use when enemy is]
    public List<Punisher> Punishers { get; set; } = [];
}