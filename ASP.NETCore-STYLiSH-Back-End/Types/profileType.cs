namespace STYLiSH.Types
{
  public record Profile
  {
    public string? email { get; set; }
    public int id { get; set; }
    public string? name { get; set; }
    public string? picture { get; set; }
    public string? provider { get; set; }
  }
}