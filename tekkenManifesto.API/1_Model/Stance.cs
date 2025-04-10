using System.Text.Json.Serialization;

namespace tekkenManifesto.API.Model;

public class Stance
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Input { get; set; } = "";
}