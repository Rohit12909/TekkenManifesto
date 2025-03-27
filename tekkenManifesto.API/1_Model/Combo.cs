using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace tekkenManifesto.API.Model;

public class Combo
{
    [JsonIgnore]
    public int Id { get; set; }
    public string TextNotation { get; set; } = "";
    public string VisualNotationURL { get; set; } = "";
    public int Damage { get; set; }
}