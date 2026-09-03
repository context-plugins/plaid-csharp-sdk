using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraReportScope>))]
public sealed record CraReportScope : StringEnum<CraReportScope>
{
    private CraReportScope(string value) : base(value)
    {
    }

    public static readonly CraReportScope PlaidNetwork = new("PLAID_NETWORK");

    public static readonly CraReportScope ClientUser = new("CLIENT_USER");

    public static CraReportScope FromValue(string value) => FromValueCore(value);
}
