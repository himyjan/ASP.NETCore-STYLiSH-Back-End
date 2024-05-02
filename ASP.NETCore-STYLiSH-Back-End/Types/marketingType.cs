using System.Text.Json;
using System.Text.Json.Serialization;

namespace STYLiSH.Types
{
  public record CarouselDetails
  {
    public long id { get; set; }
    public long product_id { get; set; }
    public required string picture { get; set; }
    public required string story { get; set; }
  }

  public record MarketingCampaigns
  {
    public required CarouselDetails[] data { get; set; }
  }

  public sealed class LongToStringConverter : JsonConverter<string>
  {
    public override string Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
      return reader.GetInt64().ToString();
    }

    public override void Write(
        Utf8JsonWriter writer,
        string value,
        JsonSerializerOptions options)
    {
      throw new NotImplementedException();
    }
  }
}