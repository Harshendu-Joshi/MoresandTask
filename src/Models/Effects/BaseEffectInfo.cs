using System.Text.Json.Serialization;

namespace Models
{
    public class BaseEffectInfo
    {
        
        

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EffectTypes EffectType { get; set; }
    }
}