using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Specifies what type of <see href="https://plaid.com/docs/auth/coverage/flow-options/#removing-manual-verification-entry-points-with-reroute-to-credentials">Reroute to Credentials</see> pane should be used in the Link session for the Same-Day Micro-deposits flow. Default behavior is <c>OPTIONAL</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RerouteToCredentials>))]
public sealed record RerouteToCredentials : StringEnum<RerouteToCredentials>
{
    private RerouteToCredentials(string value) : base(value)
    {
    }

    public static readonly RerouteToCredentials Off = new("OFF");

    public static readonly RerouteToCredentials Optional = new("OPTIONAL");

    public static readonly RerouteToCredentials Forced = new("FORCED");

    public static RerouteToCredentials FromValue(string value) => FromValueCore(value);
}
