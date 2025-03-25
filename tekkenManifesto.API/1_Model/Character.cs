namespace tekkenManifesto.API.Model;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string ImageURL { get; set; } = "";
    public string Origin { get; set; } = "";
    public string FightingStyle { get; set; } = "";
    public string History { get; set; } = "";

    public List<Combo> Combos { get; set; } = [];
}