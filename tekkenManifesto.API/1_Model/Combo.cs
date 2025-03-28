using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace tekkenManifesto.API.Model;

public class Combo
{
    [JsonIgnore]
    public int Id { get; set; }
    public string TextNotation { get; set; } = "";
    public string VisualNotationURL { get; set; } = "";
    public int Damage { get; set; }
}