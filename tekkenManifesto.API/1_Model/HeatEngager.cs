using System.Text.Json.Serialization;

namespace tekkenManifesto.API.Model;

public class HeatEngager
{
    public int Id { get; set; }
    public string Input { get; set; } = "";
    public string FramesOB { get; set; } = "";
}