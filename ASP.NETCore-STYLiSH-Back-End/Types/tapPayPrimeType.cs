namespace STYLiSH.Types
{
  public record Card
  {
    public string? prime { get; set; }
    public string? bincode { get; set; }
    public string? lastfour { get; set; }
    public string? issuer { get; set; }
    public string? issuer_zh_tw { get; set; }
    public string? bank_id { get; set; }
    public int funding { get; set; }
    public int type { get; set; }
    public string? level { get; set; }
    public string? country { get; set; }
    public string? countrycode { get; set; }
  }

  public record Affiliate_codes
  {
    public string[]? affiliate_codes { get; set; }
  }

  public record Prime
  {
    public int status { get; set; }
    public Card? card { get; set; }
    public string? clientip { get; set; }
    public string? card_identifier { get; set; }
    public Affiliate_codes? merchant_reference_info { get; set; }
  }
}