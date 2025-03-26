namespace tekkenManifesto.API.Model;

public class Combo
{
    public int Id { get; set; }
    public string TextNotation { get; set; } = "";
    public string VisualNotationURL { get; set; } = "";
    public int Damage { get; set; }

    // Heat Engagers [Input, Frames On Block]
    public Dictionary<string, string> HeatEngager { get; set; } = [];

    // Launchers [Input, Frames On Block]
    public Dictionary<string, string> Launchers { get; set; } = [];
    // Stances [Name, Input]
    public Dictionary<string, string> Stances { get; set; } = [];
    // Punishers [Input, use when enemy is]
    public Dictionary<string, string> Punishers { get; set; } = [];
}