using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A type indicating who or what last touched this object. <c>dashboard</c>, <c>link</c>, and <c>api</c> indicate the originating surface; <c>system</c> indicates Plaid. <c>retro</c> indicates a screening created retroactively via a bulk screening creation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Source>))]
public sealed record Source : StringEnum<Source>
{
    private Source(string value) : base(value)
    {
    }

    public static readonly Source Dashboard = new("dashboard");

    public static readonly Source Link = new("link");

    public static readonly Source Api = new("api");

    public static readonly Source System = new("system");

    public static readonly Source Retro = new("retro");

    public static Source FromValue(string value) => FromValueCore(value);
}
