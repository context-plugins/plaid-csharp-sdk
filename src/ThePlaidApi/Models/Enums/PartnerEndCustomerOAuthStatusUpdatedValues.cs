using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The OAuth status of the update
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerOAuthStatusUpdatedValues>))]
public sealed record PartnerEndCustomerOAuthStatusUpdatedValues : OpenStringEnum<PartnerEndCustomerOAuthStatusUpdatedValues>
{
    private PartnerEndCustomerOAuthStatusUpdatedValues(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues NotStarted = new("not-started");

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues Processing = new("processing");

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues Approved = new("approved");

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues Enabled = new("enabled");

    public static readonly PartnerEndCustomerOAuthStatusUpdatedValues AttentionRequired = new("attention-required");

    public TResult Match<TResult>(Func<TResult> onNotStarted,
        Func<TResult> onProcessing,
        Func<TResult> onApproved,
        Func<TResult> onEnabled,
        Func<TResult> onAttentionRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotStarted => onNotStarted(),
            _ when this == Processing => onProcessing(),
            _ when this == Approved => onApproved(),
            _ when this == Enabled => onEnabled(),
            _ when this == AttentionRequired => onAttentionRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotStarted,
        Action onProcessing,
        Action onApproved,
        Action onEnabled,
        Action onAttentionRequired,
        Action<string> otherwise)
    {
        if (this == NotStarted) onNotStarted();
        else if (this == Processing) onProcessing();
        else if (this == Approved) onApproved();
        else if (this == Enabled) onEnabled();
        else if (this == AttentionRequired) onAttentionRequired();
        else otherwise(Value);
    }
}
