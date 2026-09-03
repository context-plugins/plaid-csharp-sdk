using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The registry containing the party's registration with name and id
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartyRegistry>))]
public sealed record PartyRegistry : StringEnum<PartyRegistry>
{
    private PartyRegistry(string value) : base(value)
    {
    }

    public static readonly PartyRegistry Fdx = new("FDX");

    public static readonly PartyRegistry Gleif = new("GLEIF");

    public static readonly PartyRegistry Icann = new("ICANN");

    public static readonly PartyRegistry Private = new("PRIVATE");

    public static PartyRegistry FromValue(string value) => FromValueCore(value);
}
