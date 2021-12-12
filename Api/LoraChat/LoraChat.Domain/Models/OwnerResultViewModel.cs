using System.Text.Json.Serialization;

namespace LoraChat.Domain.Models
{
    public class OwnerResultViewModel
    {
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }
    }
}