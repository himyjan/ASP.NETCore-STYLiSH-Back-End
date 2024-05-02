namespace STYLiSH.Types
{
  public enum Size
  {
    S = 'S',
    M = 'M',
    L = 'L',
    Xl = 'X' + 'L'
  }

  public record Variant
  {
    public string? color_code { get; set; }
    public string? size { get; set; }
    public int? stock { get; set; }
  }

  public record ProductDetailsData
  {
    public long id { get; set; }
    public string? category { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public int? price { get; set; }
    public string? texture { get; set; }
    public string? wash { get; set; }
    public string? place { get; set; }
    public string? note { get; set; }
    public string? story { get; set; }
    public string? main_image { get; set; }
    public List<string>? images { get; set; }
    public List<Variant>? variants { get; set; }
    public List<Color>? colors { get; set; }
    public List<string>? sizes { get; set; }
  }

  public record ProductsSearch
  {
    public List<ProductDetailsData>? data { get; set; }
    public int? next_paging { get; set; }
  }

  public record ProductDetails
  {
    public ProductDetailsData? data { get; set; }
  }
}