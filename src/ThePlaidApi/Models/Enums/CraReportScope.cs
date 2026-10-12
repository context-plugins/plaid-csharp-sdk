using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraReportScope>))]
public sealed record CraReportScope : OpenStringEnum<CraReportScope>
{
    private CraReportScope(string value) : base(value)
    {
    }

    public static readonly CraReportScope PlaidNetwork = new("PLAID_NETWORK");

    public static readonly CraReportScope ClientUser = new("CLIENT_USER");

    public TResult Match<TResult>(Func<TResult> onPlaidNetwork,
        Func<TResult> onClientUser,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PlaidNetwork => onPlaidNetwork(),
            _ when this == ClientUser => onClientUser(),
            _ => otherwise(Value)
        };

    public void Match(Action onPlaidNetwork, Action onClientUser, Action<string> otherwise)
    {
        if (this == PlaidNetwork) onPlaidNetwork();
        else if (this == ClientUser) onClientUser();
        else otherwise(Value);
    }
}
