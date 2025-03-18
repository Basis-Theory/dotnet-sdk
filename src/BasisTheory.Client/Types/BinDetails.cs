using System.Text.Json.Serialization;
using BasisTheory.Client.Core;

namespace BasisTheory.Client;

public record BinDetails
{
    [JsonPropertyName("card_brand")]
    public string? CardBrand { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("prepaid")]
    public bool? Prepaid { get; set; }

    [JsonPropertyName("card_segment_type")]
    public string? CardSegmentType { get; set; }

    [JsonPropertyName("bank")]
    public BinDetailsBank? Bank { get; set; }

    [JsonPropertyName("product")]
    public BinDetailsProduct? Product { get; set; }

    [JsonPropertyName("country")]
    public BinDetailsCountry? Country { get; set; }

    [JsonPropertyName("reloadable")]
    public bool? Reloadable { get; set; }

    [JsonPropertyName("pan_or_token")]
    public string? PanOrToken { get; set; }

    [JsonPropertyName("account_updater")]
    public bool? AccountUpdater { get; set; }

    [JsonPropertyName("alm")]
    public bool? Alm { get; set; }

    [JsonPropertyName("domestic_only")]
    public bool? DomesticOnly { get; set; }

    [JsonPropertyName("gambling_blocked")]
    public bool? GamblingBlocked { get; set; }

    [JsonPropertyName("level2")]
    public bool? Level2 { get; set; }

    [JsonPropertyName("level3")]
    public bool? Level3 { get; set; }

    [JsonPropertyName("issuer_currency")]
    public string? IssuerCurrency { get; set; }

    [JsonPropertyName("combo_card")]
    public string? ComboCard { get; set; }

    [JsonPropertyName("bin_length")]
    public int? BinLength { get; set; }

    [JsonPropertyName("authentication")]
    public object? Authentication { get; set; }

    [JsonPropertyName("cost")]
    public object? Cost { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
