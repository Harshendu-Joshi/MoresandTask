using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    //   [JsonConverter(typeof(JsonStringEnumConverterverter))]
    public enum EffectTypes
    {
        RetroPhoto = 1,
        BlurImage = 2,
        GarayScale = 3
    }
}