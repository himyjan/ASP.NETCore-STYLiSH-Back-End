namespace STYLiSH.Types
{
  public record Color
  {
    public string? code { get; set; }
    public string? name { get; set; }
  }

  public record CartItem
  {
    public string? id { get; set; }
    public Color? color { get; set; }
    public string? size { get; set; }
    public string? image { get; set; }
    public string? name { get; set; }
    public int qty { get; set; }
    public int price { get; set; }
    public int stock { get; set; }
  }
}