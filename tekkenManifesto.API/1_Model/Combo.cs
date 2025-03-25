namespace tekkenManifesto.API.Model;

public class Combo
{
    public int Id { get; set; }
    public string TextNotation { get; set; } = "";
    public string VisualNotationURL { get; set; } = "";
    public int Damage { get; set; }
}