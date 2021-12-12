using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace LoraChat.Domain.Models
{
    public class RepositoriesResultViewModel
    {
        [JsonPropertyName("full_name")] public string FullName { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; }
        [JsonPropertyName("language")] public string Language { get; set; }
        [JsonPropertyName("owner")] public OwnerResultViewModel Owner { get; set; }
    }
}