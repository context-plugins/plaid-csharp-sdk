using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum representing the overall network status of the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkStatusGetResponseNetworkStatus>))]
public sealed record NetworkStatusGetResponseNetworkStatus : OpenStringEnum<NetworkStatusGetResponseNetworkStatus>
{
    private NetworkStatusGetResponseNetworkStatus(string value) : base(value)
    {
    }

    public static readonly NetworkStatusGetResponseNetworkStatus Unknown = new("UNKNOWN");

    public static readonly NetworkStatusGetResponseNetworkStatus ReturningUser = new("RETURNING_USER");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onReturningUser,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == ReturningUser => onReturningUser(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown, Action onReturningUser, Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == ReturningUser) onReturningUser();
        else otherwise(Value);
    }
}
