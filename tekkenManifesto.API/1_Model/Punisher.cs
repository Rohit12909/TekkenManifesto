using System.Text.Json.Serialization;

namespace tekkenManifesto.API.Model;

public class Punisher
{
    public int Id { get; set; }
    public string Input { get; set; } = "";
    public string EnemyIs { get; set; } = "";
}